#include <EEPROM.h>

volatile uint8_t mainIndex = 0;

#include "button.h"
#include "display.h"
#include "timer.h"

#include "bluetooth.h"
#include "usb.h"

void main0() {
  display.l7s = timer.second;
  if(button.status[0] == press) display.led = display.led >> 1;
  if(button.status[1] == press) display.led = (display.led << 1) + 1;
}

void main1() {
  
}

void main2() {
  
}

void main3() {
  
}

void mainLoop() {
  switch(mainIndex) {
    case 0: main0(); break;
    case 1: main1(); break;
    case 2: main2(); break;
    case 3: main3(); break;
  }
}

void setup() {
  bluetooth.Init();
  button.Init();
  display.Init();
  timer.Init();
  usbInit();
  
  for(uint8_t i=0; i<8; i++) display.SetRGB(i, 0, 0, 0);
  FastLED.show();
}

void loop() {
  static uint8_t offset = 0;
  
  mainLoop();
  
  button.Loop();
  display.Loop();
  
  
  if(++offset == 20) {
    offset = 0;
    
    bluetooth.Send();
    bluetooth.Receive();
  }
  
  delay(1);
}
