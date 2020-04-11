#include <ESP8266WiFi.h>
const char* ssid     = "WireShark";
const char* password = "p@&&3ard100%";
int x = D5;
   const uint16_t port = 8000;
  const char * host = "192.168.0.11";
  
void setup() {
  pinMode(x,INPUT);
  Serial.begin(115200);
  WiFi.disconnect(true);
  delay(1000);
  WiFi.begin(ssid, password);
  digitalWrite(x,1);
  
  
  
}

void loop() {
//  WiFiClient client;
//  client.connect(host, port);
  if(digitalRead(x) == 0){
    Serial.println("pressed");
  }
//  if(digitalRead(x) == 0){
//  client.print('0');
//  client.flush();
//  client.stop();
//  }
}
