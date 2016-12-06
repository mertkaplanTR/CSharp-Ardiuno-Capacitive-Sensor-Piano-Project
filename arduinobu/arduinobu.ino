int fsrAnalogPinSifir = A0; // FSR is connected to analog 0
int fsrAnalogPinBir=A1;
int fsrAnalogPinIki=A2;
int fsrAnalogPinUc=A3;
int fsrAnalogPinDort=A4;
int fsrAnalogPinBes=A5;
int LEDpinSifir = 12;      // connect Red LED to pin 12 (PWM pin)
int LEDpinBir=11;
int LEDpinIki=10;
int LEDpinUc=9;
int LEDpinDort=8;
int LEDpinBes=7;
int fsrReadingBir;      
int fsrReadingIki;
int fsrReadingUc;
int fsrReadingDort;
int fsrReadingBes;
int fsrReadingAlti;

void setup(void) {
  Serial.begin(9600);   
  pinMode(LEDpinSifir, OUTPUT);
  pinMode(LEDpinBir, OUTPUT);
  pinMode(LEDpinIki, OUTPUT);
  pinMode(LEDpinUc, OUTPUT);
  pinMode(LEDpinDort, OUTPUT);
  pinMode(LEDpinBes, OUTPUT);
}
 
void loop(void) 
{
  fsrReadingBir = analogRead(fsrAnalogPinSifir);
  fsrReadingIki=analogRead(fsrAnalogPinBir);
  fsrReadingUc=analogRead(fsrAnalogPinIki);
  fsrReadingDort=analogRead(fsrAnalogPinUc); 
  fsrReadingBes=analogRead(fsrAnalogPinDort);
  fsrReadingAlti=analogRead(fsrAnalogPinBes);
  
  int led0=fsrReadingBir/2; 
  int led1=fsrReadingIki/4; 
  int led2=fsrReadingUc/6;
  int led3=fsrReadingDort/8;
  int led4=fsrReadingBes/10;
  int led5=fsrReadingAlti/12;

  //BURANIN ALTINDAKI COMMENTLERI KALDIR!!!!!!!!!!!
 // Serial.print("Analog reading led0= "); 
  Serial.println(led0);
 // Serial.print("-");
  //Serial.print("Analog reading led1= "); 
  Serial.println(led1);
 /* Serial.print("\n");
  Serial.print("Analog reading led2= "); 
  Serial.println(led2);
  Serial.print("\n");
  Serial.print("Analog reading led3= "); 
  Serial.println(led3);
   Serial.print("------------------------");
  Serial.print("\n");*/
  
  
  
   if(led0 >= 480 || led0 <=520)
   {
    digitalWrite(12,HIGH);
   }
   if(led0 <=480)
   {
    digitalWrite(12,LOW);
   }
 /////////////////////LED0 ICIN CONDITION BITISI

    if(led1 >= 240 || led0 <=260)
   {
    digitalWrite(11,HIGH);
   }
   if(led1 <=240)
   {
    digitalWrite(11,LOW);
   }
 


   
  ///asil kod asagıda
////bu yok used by analogWrite (0-255) with map!
//  LEDbrightness = map(num, 0, 1023, 0, 255);
  // LED gets brighter the harder you press
  //analogWrite(LEDpin, LEDbrightness);
 
  delay(1000);
}
