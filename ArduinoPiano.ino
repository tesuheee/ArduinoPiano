const int pin = 12;
int times = 200;
int octave = 10;
void setup() {
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0) {
    char data = (Serial.read());
    switch (data) {
      case 'C':
        tone(pin, 262/octave, times);
        delay(times) ;
        break;

      case 'D':
        tone(pin, 294/octave, times);
        delay(times) ;
        break;

      case 'E':
        tone(pin, 330/octave, times);
        delay(times) ;
        break;

      case 'F':
        tone(pin, 349/octave, times);
        delay(times) ;
        break;

      case 'G':
        tone(pin, 392/octave, times);
        delay(times) ;
        break;

      case 'A':
        tone(pin, 440/octave, times);
        delay(times) ;
        break;

      case 'B':
        tone(pin, 494/octave, times);
        delay(times) ;
        break;

      case 'c':
        tone(pin, 523/octave, times);
        delay(times) ;
        break;
    }

  }


}
