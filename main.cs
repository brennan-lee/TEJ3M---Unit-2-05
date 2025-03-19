/*
* Created by: Brennan Lee
* Created on: Mar 2025
* This program controls a servo motor
*/

#include ‹Servo.h>

Servo servoNumber1;

void setup () {
        // setup servo pins
        servoNumber1. attach(2) ; 
        servoNumber1.write(0);
}

void loop() {
        // put your main code here, to run repeatedly:
        servoNumber1. write (90);
        delay (1000);
        servoNumber1.write(0);
        delay (1000);
}