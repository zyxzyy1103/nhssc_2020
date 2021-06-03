#ifndef _DISPLAY_H_
#define _DISPLAY_H_

#include <FastLED.h>

const uint8_t LATCH_P = 8;
const uint8_t CLOCK_P = 12;
const uint8_t DATA_P  = 11;

const uint8_t LED_E = 7;
const uint8_t L7S_E = 13;

// LED
//uint8_t LED_D[] = {A0,A1,A2,A3,A4,5,6,7};
//#define LED_E 11

// L7S
//uint8_t L7S_D[] = {A0,A1,A2,A3,A4,5,6,7};
//#define L7S_E 12

// RGB
const uint8_t RGB_P = 3;
const uint8_t RGB_N = 8;

const uint8_t NUMBER_TO_BYTE[] = {
  0b00111111,
  0b00000110,
  0b01011011,
  0b01001111,
  0b01100110,
  0b01101101,
  0b01111100,
  0b00000111,
  0b01111111,
  0b01100111,
};

class CDisplay {
  public:
    void Init();
    void Loop();
    void SetRGB(uint8_t i, uint8_t r, uint8_t g, uint8_t b);
    
    uint8_t led;
    uint8_t l7s;
    uint8_t rgbData[8][3];
    CRGB    rgb[8];
}display;

void CDisplay::SetRGB(uint8_t i, uint8_t r, uint8_t g, uint8_t b) {
  display.rgbData[i][0] = r;
  display.rgbData[i][1] = g;
  display.rgbData[i][2] = b;
  display.rgb[i] = CRGB(r, g, b);
}

void CDisplay::Init() {
  uint8_t i;

  pinMode(LATCH_P, 1);
  pinMode(CLOCK_P, 1);
  pinMode(DATA_P,  1);

  pinMode(LED_E, 1);
  pinMode(L7S_E, 1);

  // LED
  //for(i=0; i<8; i++) pinMode(LED_D[i], 1);
  //pinMode(LED_E, 1);
  //digitalWrite(LED_E, 0);

  // L7S
  //for(i=0; i<8; i++) pinMode(L7S_D[i], 1);
  //pinMode(L7S_E, 1);
  //digitalWrite(L7S_E, 0);

  // RGB
  FastLED.addLeds<WS2812, RGB_P, GRB>(rgb, RGB_N);
  FastLED.setBrightness(32);
}

void CDisplay::Loop()
{
  static uint8_t line = 0;
  uint8_t i, l7sBuffer;

  if (line == 0)
  {
    digitalWrite(LED_E, HIGH);
    digitalWrite(L7S_E, LOW);

    digitalWrite(LATCH_P, LOW);
    shiftOut(DATA_P, CLOCK_P, MSBFIRST, led);
    digitalWrite(LATCH_P, HIGH);

    digitalWrite(LED_E, LOW);
  }
  else if (line == 1)
  {
    l7sBuffer = ((l7s / 10) << 4) + (l7s % 10);

    digitalWrite(LED_E, HIGH);
    digitalWrite(L7S_E, LOW);

    digitalWrite(LATCH_P, LOW);
    shiftOut(DATA_P, CLOCK_P, MSBFIRST, l7sBuffer);
    digitalWrite(LATCH_P, HIGH);

    digitalWrite(L7S_E, HIGH);
  }

  if (++line == 2)
    line = 0;

  /*
  // LED
  digitalWrite(L7S_E, 0);
  for(i=0; i<8; i++) digitalWrite(LED_D[i], (led >> i) % 2);
  digitalWrite(LED_E, 1);
  
  // L7S
  digitalWrite(LED_E, 0);
  l7sBuffer = ((l7s / 10) << 4) + (l7s % 10);
  for(i=0; i<8; i++) digitalWrite(L7S_D[i], (l7sBuffer >> i) % 2);
  digitalWrite(L7S_E, 1);
  */
}

#endif
