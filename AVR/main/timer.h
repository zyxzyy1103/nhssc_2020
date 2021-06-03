#ifndef _TIMER_H_
#define _TIMER_H_

#include "usbdrv.h"

class CTimer {
public:
  void Init();
  void MillisChange();

  uint16_t millis;
  uint8_t second;
  uint8_t minute;
  uint8_t hour;
  uint8_t day;
  uint8_t month;

  bool half;
  bool quarter;
  bool eight;
  bool deci;
} timer;

void CTimer::MillisChange() {
  if (++millis == 1000) {
    millis = 0;
    if (++second == 60) {
      second = 0;
      if (++minute == 60) {
        minute = 0;
        if (++hour == 24) {
          hour = 0;
        }
      }
    }
  }

  half = ((millis / 500) % 2) ? true : false;
  quarter = ((millis / 250) % 2) ? true : false;
  eight = ((millis / 125) % 2) ? true : false;
  deci = ((millis / 100) % 2) ? true : false;
}

void CTimer::Init() {
  TCNT2 = 0;
  TCCR2A |= (1 << WGM21);
  TCCR2B |= (1 << CS22);
  TIMSK2 |= (1 << OCIE2A);
  OCR2A = 16000000 / 1000000L * 1000 / 64;
}

ISR(TIMER2_COMPA_vect) {
  sei();
  usbPoll();
  timer.MillisChange();
}

#endif
