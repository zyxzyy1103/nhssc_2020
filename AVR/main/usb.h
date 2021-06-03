#ifndef _USB_H_
#define _USB_H_

#include "usbdrv.h"

USB_PUBLIC uchar usbFunctionRead(uchar *data, uchar len);
USB_PUBLIC uchar usbFunctionWrite(uchar *data, uchar len);
USB_PUBLIC usbMsgLen_t usbFunctionSetup(uchar data[8]);

const uint8_t usbHidReportDescriptor[22] PROGMEM = {
    0x06, 0x00, 0xff, // USAGE_PAGE (Generic Desktop)
    0x09, 0x01,       // USAGE (Vendor Usage 1)
    0xa1, 0x01,       // COLLECTION (Application)
    0x15, 0x00,       //   LOGICAL_MINIMUM (0)
    0x26, 0xff, 0x00, //   LOGICAL_MAXIMUM (255)
    0x75, 0x08,       //   REPORT_SIZE (8)
    0x95, 0x80,       //   REPORT_COUNT (1)
    0x09, 0x00,       //   USAGE (Undefined)
    0xb2, 0x02, 0x01, //   FEATURE (Data,Var,Abs,Buf)
    0xc0              // END_COLLECTION
};

static uchar currentAddress;
static uchar bytesRemaining;

uint8_t usbCmdH = 99;
uint8_t usbCmdL = 0;

USB_PUBLIC uchar usbFunctionRead(uchar *data, uchar len) {
  if(bytesRemaining == 0)  return 0;
  if(bytesRemaining != 8)  return 0xff;
  if(len > bytesRemaining) len = bytesRemaining;
  if(currentAddress == 0) {
    if (usbCmdH != 99) {
      if (usbCmdH == 66 && usbCmdL == 0) {
        static uint8_t usbIndex = 0;

        *(data + 0) = 0b11110000 + usbIndex;
        *(data + 1) = mainIndex;
        *(data + 2) = display.led;
        *(data + 3) = display.l7s;
        *(data + 4) = display.rgbData[usbIndex][0];
        *(data + 5) = display.rgbData[usbIndex][1];
        *(data + 6) = display.rgbData[usbIndex][2];
        *(data + 7) = button.buttonDown[0] + 2 * button.buttonDown[1] + 4 * button.buttonDown[2] + 8 * button.buttonDown[3];

        if (++usbIndex == 8) usbIndex = 0;
      }
      usbCmdH = 99;
    }
  }

  currentAddress += len;
  bytesRemaining -= len;
  return len;
}

USB_PUBLIC uchar usbFunctionWrite(uchar *data, uchar len) {
  if(bytesRemaining == 0)  return 1;
  if(bytesRemaining != 8)  return 0xff;
  if(len > bytesRemaining) len = bytesRemaining;
  if(currentAddress == 0) {
    usbCmdH = *(data + 0);
    usbCmdL = *(data + 1);

    switch(usbCmdH) {
    // TIME
    case 0: {
      timer.millis = 0;
      timer.second = *(data + 2);
      timer.minute = *(data + 3);
      timer.hour = *(data + 4);
      timer.day = *(data + 5);
      timer.month = *(data + 6);
      break;
    }
    // MAIN INDEX
    case 1: {
      mainIndex = usbCmdL;
      break;
    }
    // LED CHANGE
    case 2: {
      switch (usbCmdL) {
      // 個別控制
      case 0:
        display.led = display.led ^ *(data + 2);
        break;
      //
      case 1:
        display.led = 0b10101010;
        break;
      case 2:
        display.led = 0b01010101;
        break;
      case 3:
        display.led = 0b00000000;
        break;
      }
      break;
    }
    // RGB CHANGE
    case 3: {
      display.SetRGB(usbCmdL, *(data + 2), *(data + 3), *(data + 4));
      FastLED.show();
      break;
    }
    // BUTTON CHANGE
    case 4: {
      button.mouseDown[usbCmdL] = 1;
      break;
    }
    case 5: {
      EEPROM.write(0, usbCmdL);
      break;
    }
    case 6: {

      break;
    }
    }
  }
  if(usbCmdH != 66) usbCmdH = 99;

  currentAddress += len;
  bytesRemaining -= len;
  return bytesRemaining == 0;
}

USB_PUBLIC usbMsgLen_t usbFunctionSetup(uchar data[8]) {
  usbRequest_t *rq = (void *)data;
  if ((rq->bmRequestType & USBRQ_TYPE_MASK) == USBRQ_TYPE_CLASS) {
    if (rq->bRequest == USBRQ_HID_SET_REPORT) {
      bytesRemaining = 8;
      currentAddress = 0;
      return USB_NO_MSG;
    }
    else if (rq->bRequest == USBRQ_HID_GET_REPORT) {
      bytesRemaining = 8;
      currentAddress = 0;
      return USB_NO_MSG;
    }
  }
  return 0;
}

#endif
