#ifndef _BLUETOOTH_H_
#define _BLUETOOTH_H_


#include <SoftwareSerial.h>
#include <Wire.h>

#include "timer.h"


String IntToHex(uint8_t n) {
  String s;

  if (n < 10)
    s = n;
  switch (n) {
  case 10:
    s = "A";
    break;
  case 11:
    s = "B";
    break;
  case 12:
    s = "C";
    break;
  case 13:
    s = "D";
    break;
  case 14:
    s = "E";
    break;
  case 15:
    s = "F";
    break;
  }

  return s;
}

String GetRGB(uint8_t index) {
  String s;

  for (uint8_t i = index; i < index + 2; i++) {
    String ts = "";
    ts = ts + IntToHex(display.rgbData[i][0] / 16) + IntToHex(display.rgbData[i][0] % 16);
    ts = ts + IntToHex(display.rgbData[i][1] / 16) + IntToHex(display.rgbData[i][1] % 16);
    ts = ts + IntToHex(display.rgbData[i][2] / 16) + IntToHex(display.rgbData[i][2] % 16);
    s = s + ts;
  }

  return s;
}

class CBluetooth {
public:
  void Init();
  void Receive();
  void Send();
  
  String data;
  uint16_t timeoffset = 0;
  //SoftwareSerial BT(10,11);
} bluetooth;

void CBluetooth::Send() {
  static uint8_t index = 0;
  String d = "<";

  switch (index) {
  case 0: {
    d = d + "a0" + mainIndex;
    break;
  }
  case 1: {
    d = d + "b0" + display.led;
    break;
  }
  case 2: {
    d = d + "c0" + display.l7s;
    break;
  }
  case 3: {
    d = d + "d0" + GetRGB(0);
    break;
  }
  case 4: {
    d = d + "d1" + GetRGB(2);
    break;
  }
  case 5: {
    d = d + "d2" + GetRGB(4);
    break;
  }
  case 6: {
    d = d + "d3" + GetRGB(6);
    break;
  }
  }

  d = d + ">";
  Serial.print(d);

  if(++index == 7) index = 0;
}

void CBluetooth::Init() {
  Serial.begin(9600);
  Serial.setTimeout(5);
}

void CBluetooth::Receive() {
  if(Serial.available()) {
    data = Serial.readString();
    
    uint8_t d[8];
    
    char c[99];
    strcpy(c, data.c_str());

    char *s = strtok(c, ",");
    uint8_t sCount = 0;

    while(s != NULL) {
      d[sCount++] = atoi(s);
      s = strtok(NULL, ",");
    }

    if(d[7] == 0) {
      switch(d[0]) {
      case 0: {
        timer.millis = 0;
        timer.second = d[2];
        timer.minute = d[3];
        timer.hour = d[4];
        break;
      }
      case 1: {
        mainIndex = d[1];
        break;
      }
      case 2: {
        switch(d[1]) {
          case 0: display.led = display.led ^ d[2]; break;
          case 1: display.led = 0b10101010; break;
          case 2: display.led = 0b01010101; break;
          case 3: display.led = 0b00000000; break;
        }
        break;
      }
      case 3: {
        display.SetRGB(d[1], d[2], d[3], d[4]);
        FastLED.show();
        break;
      }
      case 4: {
        button.mouseDown[d[1]] = 1;
        break;
      }
      case 5: {
        //EEPROM.write(0, d[2]);
        break;
      }
      case 6: {

        break;
      }
      }
    }
  }
}

void serialEvent() {
  //bluetooth.data = "";

  //bluetooth.Receive();
}

#endif
