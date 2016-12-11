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
  digitalWrite(12,HIGH);
  delay(1000);
  digitalWrite(12,LOW);

  digitalWrite(11,HIGH);
  delay(1000);
  digitalWrite(11,LOW);

    digitalWrite(10,HIGH);
  delay(1000);
  digitalWrite(10,LOW);

    digitalWrite(9,HIGH);
  delay(1000);
  digitalWrite(9,LOW);

      digitalWrite(8,HIGH);
  delay(1000);
  digitalWrite(8,LOW);

      digitalWrite(7,HIGH);
  delay(1000);
  digitalWrite(7,LOW);
  
delay(500);
    digitalWrite(12,HIGH);
        digitalWrite(11,HIGH);
            digitalWrite(10,HIGH);
                digitalWrite(9,HIGH);
                  digitalWrite(8,HIGH);
                  digitalWrite(7,HIGH);
  delay(1500);
  
    digitalWrite(12,LOW);
        digitalWrite(11,LOW);
            digitalWrite(10,LOW);
                digitalWrite(9,LOW);
                  digitalWrite(8,LOW);
  digitalWrite(7,LOW);
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
  int led2=fsrReadingUc*3;
  int led3=fsrReadingDort*4;
  int led4=fsrReadingBes*5;
  int led5=fsrReadingAlti*6;

  //BURANIN ALTINDAKI COMMENTLERI KALDIR!!!!!!!!!!!
 // Serial.print("Analog reading led0= "); 
  //Serial.println(led0);
 // Serial.print("-");
  //Serial.print("Analog reading led1= "); 
 
 /* Serial.print("\n");
  Serial.print("Analog reading led2= "); 
  Serial.println(led2);
  Serial.print("\n");
  Serial.print("Analog reading led3= "); 
  Serial.println(led3);
   Serial.print("------------------------");
  Serial.print("\n");*/
  

 
   if(led0 >= 480 && led0 <=520)
   {
   // Serial.println("LED 0'a dokundun: ");
    Serial.println(led0);
    digitalWrite(12,HIGH);
   }
   else
   {
    digitalWrite(12,LOW);
  }
 
 /////////////////////LED 0 ICIN CONDITION BITISI

   
    if(led1>=200 && led1<=260)
   {
    //Serial.println("LED 1'e dokundun: ");
    Serial.println(led1);
    digitalWrite(11,HIGH);
     
   }
   else
   {
    digitalWrite(11,LOW);
   }

   /////////////////////LED1 ICIN CONDITION BITISI

       
    if(led2>=2950 && led2<=3050)
   {
     Serial.println(led2);
    digitalWrite(10,HIGH);
     
   }
   else
   {
    digitalWrite(10,LOW);
   }
 /////////////////////LED2 ICIN CONDITION BITISI
   
   
    if(led3>=3800 && led3<=4150)
   {
     Serial.println(led3);
    digitalWrite(9,HIGH);
     
   }
   else
   {
    digitalWrite(9,LOW);
   }
 /////////////////////LED2 ICIN CONDITION BITISI

  
   
    if(led4>=4850 && led4<=5300)
   {
     Serial.println(led4);
    digitalWrite(8,HIGH);
     
   }
   else
   {
    digitalWrite(8,LOW);
   }

    if(led5>=6050 && led5<=6200)
   {
     Serial.println(led5);
    digitalWrite(7,HIGH);
     
   }
   else
   {
    digitalWrite(7,LOW);
   }

////////////////////////////
if(Serial.available())
{
  int a=Serial.read();
  if(a=='0')
  {
    digitalWrite(12,HIGH);
    }
    else
    {digitalWrite(12,LOW);
      }
  }

   
  ///asil kod asagıda
////bu yok used by analogWrite (0-255) with map!
//  LEDbrightness = map(num, 0, 1023, 0, 255);
  // LED gets brighter the harder you press
  //analogWrite(LEDpin, LEDbrightness);
  delay(100);
  //delay(1000);
}
