const int totalReadings = 10;

int mq2Readings[totalReadings];
int mq2ReadIndex = 0;
int mq2Total = 0;
int mq2Average = 0;
int mq2Status = 0;

int mq3Readings[totalReadings];
int mq3ReadIndex = 0;
int mq3Total = 0;
int mq3Average = 0;
int mq3Status = 0;

int mq4Readings[totalReadings];
int mq4ReadIndex = 0;
int mq4Total = 0;
int mq4Average = 0;
int mq4Status = 0;

int mq5Readings[totalReadings];
int mq5ReadIndex = 0;
int mq5Total = 0;
int mq5Average = 0;
int mq5Status = 0;

int mq8Readings[totalReadings];
int mq8ReadIndex = 0;
int mq8Total = 0;
int mq8Average = 0;
int mq8Status = 0;

int mq9Readings[totalReadings];
int mq9ReadIndex = 0;
int mq9Total = 0;
int mq9Average = 0;
int mq9Status = 0;

int overrideStatus = 0;

float warningThreshold = 0.05;
float alarmThreshold = 0.10;

int systemStatusPin = 13;
int overridePin = 10;

class checkSensor
  {
    private:
    int refreshInterval; 
    int sensorPin;
    unsigned long previousTime;
    int sensor;
    int sensorValue;
    int warningValue;
    int alarmValue;

    public:
    checkSensor(int varSensor, int pin, int interval)
      {
        refreshInterval = interval;
        sensorPin = pin;
        previousTime = 0;
        sensor = varSensor;
      }

    void Update()
      {
        unsigned long currentTime = millis();

        if (currentTime - previousTime >= refreshInterval)
          {
            if (sensor == 2)
              {
                mq2Total = mq2Total - mq2Readings[mq2ReadIndex];
                mq2Readings[mq2ReadIndex] = analogRead(sensorPin);
                mq2Total = mq2Total + mq2Readings[mq2ReadIndex]; 
                mq2ReadIndex = mq2ReadIndex + 1;
                if (mq2ReadIndex >= totalReadings)
                  {
                    mq2ReadIndex = 0;
                  }
                mq2Average = mq2Total / totalReadings;
                sensorValue = mq2Average;
                warningValue = mq2Average + (mq2Average * warningThreshold);
                alarmValue = mq2Average + (mq2Average * alarmThreshold);
                Serial.print("<MQ2INP");
                Serial.print(mq2Readings[mq2ReadIndex]);
                Serial.println(">");
                Serial.print("<MQ2AVG");
                Serial.print(sensorValue);
                Serial.println(">");
                Serial.print("<MQ2WRN");
                Serial.print(warningValue);
                Serial.println(">");
                Serial.print("<MQ2ALM");
                Serial.print(alarmValue);
                Serial.println(">");
              }
            if (sensor == 3)
              {
                mq3Total = mq3Total - mq3Readings[mq3ReadIndex];
                mq3Readings[mq3ReadIndex] = analogRead(sensorPin);
                mq3Total = mq3Total + mq3Readings[mq3ReadIndex]; 
                mq3ReadIndex = mq3ReadIndex + 1;
                if (mq3ReadIndex >= totalReadings)
                  {
                    mq3ReadIndex = 0;
                  }
                mq3Average = mq3Total / totalReadings;
                sensorValue = mq3Average;
                warningValue = mq3Average + (mq3Average * warningThreshold);
                alarmValue = mq3Average + (mq3Average * alarmThreshold);
                Serial.print("<MQ3INP");
                Serial.print(mq3Readings[mq3ReadIndex]);
                Serial.println(">");
                Serial.print("<MQ3AVG");
                Serial.print(sensorValue);
                Serial.println(">");
                Serial.print("<MQ3WRN");
                Serial.print(warningValue);
                Serial.println(">");
                Serial.print("<MQ3ALM");
                Serial.print(alarmValue);
                Serial.println(">");
              }
            if (sensor == 4)
              {
                mq4Total = mq4Total - mq4Readings[mq4ReadIndex];
                mq4Readings[mq4ReadIndex] = analogRead(sensorPin);
                mq4Total = mq4Total + mq4Readings[mq4ReadIndex]; 
                mq4ReadIndex = mq4ReadIndex + 1;
                if (mq4ReadIndex >= totalReadings)
                  {
                    mq4ReadIndex = 0;
                  }
                mq4Average = mq4Total / totalReadings;
                sensorValue = mq4Average;
                warningValue = mq4Average + (mq4Average * warningThreshold);
                alarmValue = mq4Average + (mq4Average * alarmThreshold);
                Serial.print("<MQ4INP");
                Serial.print(mq4Readings[mq4ReadIndex]);
                Serial.println(">");
                Serial.print("<MQ4AVG");
                Serial.print(sensorValue);
                Serial.println(">");
                Serial.print("<MQ4WRN");
                Serial.print(warningValue);
                Serial.println(">");
                Serial.print("<MQ4ALM");
                Serial.print(alarmValue);
                Serial.println(">");
              }
            if (sensor == 5)
              {
                mq5Total = mq5Total - mq5Readings[mq5ReadIndex];
                mq5Readings[mq5ReadIndex] = analogRead(sensorPin);
                mq5Total = mq5Total + mq5Readings[mq5ReadIndex]; 
                mq5ReadIndex = mq5ReadIndex + 1;
                if (mq5ReadIndex >= totalReadings)
                  {
                    mq5ReadIndex = 0;
                  }
                mq5Average = mq5Total / totalReadings;
                sensorValue = mq5Average;
                warningValue = mq5Average + (mq5Average * warningThreshold);
                alarmValue = mq5Average + (mq5Average * alarmThreshold);
                Serial.print("<MQ5INP");
                Serial.print(mq5Readings[mq5ReadIndex]);
                Serial.println(">");
                Serial.print("<MQ5AVG");
                Serial.print(sensorValue);
                Serial.println(">");
                Serial.print("<MQ5WRN");
                Serial.print(warningValue);
                Serial.println(">");
                Serial.print("<MQ5ALM");
                Serial.print(alarmValue);
                Serial.println(">");
              }
            if (sensor == 8)
              {
                mq8Total = mq8Total - mq8Readings[mq8ReadIndex];
                mq8Readings[mq8ReadIndex] = analogRead(sensorPin);
                mq8Total = mq8Total + mq8Readings[mq8ReadIndex]; 
                mq8ReadIndex = mq8ReadIndex + 1;
                if (mq8ReadIndex >= totalReadings)
                  {
                    mq8ReadIndex = 0;
                  }
                mq8Average = mq8Total / totalReadings;
                sensorValue = mq8Average;
                warningValue = mq8Average + (mq8Average * warningThreshold);
                alarmValue = mq8Average + (mq8Average * alarmThreshold);
                Serial.print("<MQ8INP");
                Serial.print(mq8Readings[mq8ReadIndex]);
                Serial.println(">");
                Serial.print("<MQ8AVG");
                Serial.print(sensorValue);
                Serial.println(">");
                Serial.print("<MQ8WRN");
                Serial.print(warningValue);
                Serial.println(">");
                Serial.print("<MQ8ALM");
                Serial.print(alarmValue);
                Serial.println(">");
              }
            if (sensor == 9)
              {
                mq9Total = mq9Total - mq9Readings[mq9ReadIndex];
                mq9Readings[mq9ReadIndex] = analogRead(sensorPin);
                mq9Total = mq9Total + mq9Readings[mq9ReadIndex]; 
                mq9ReadIndex = mq9ReadIndex + 1;
                if (mq9ReadIndex >= totalReadings)
                  {
                    mq9ReadIndex = 0;
                  }
                mq9Average = mq9Total / totalReadings;
                sensorValue = mq9Average;
                warningValue = mq9Average + (mq9Average * warningThreshold);
                alarmValue = mq9Average + (mq9Average * alarmThreshold);
                Serial.print("<MQ9INP");
                Serial.print(mq9Readings[mq9ReadIndex]);
                Serial.println(">");
                Serial.print("<MQ9AVG");
                Serial.print(sensorValue);
                Serial.println(">");
                Serial.print("<MQ9WRN");
                Serial.print(warningValue);
                Serial.println(">");
                Serial.print("<MQ9ALM");
                Serial.print(alarmValue);
                Serial.println(">");
              }
            if (sensorValue < warningValue)
              {
                if (sensor == 2)
                  {
                    mq2Status = 0;
                  }
                else if (sensor == 3)
                  {
                    mq3Status = 0;
                  }
                else if (sensor == 4)
                  {
                    mq4Status = 0;
                  }
                else if (sensor == 5)
                  {
                    mq5Status = 0;
                  }
                else if (sensor == 8)
                  {
                    mq8Status = 0;
                  }
                else if (sensor == 9)
                  {
                    mq9Status = 0;
                  }
              }
            else if ((sensorValue >= warningValue) && (sensorValue < alarmValue))
              {
                if (sensor == 2)
                  {
                    mq2Status = 1;
                  }
                else if (sensor == 3)
                  {
                    mq3Status = 1;
                  }
                else if (sensor == 4)
                  {
                    mq4Status = 1;
                  }
                else if (sensor == 5)
                  {
                    mq5Status = 1;
                  }
                else if (sensor == 8)
                  {
                    mq8Status = 1;
                  }
                else if (sensor == 9)
                  {
                    mq9Status = 1;
                  }
              }
            else if (sensorValue >= alarmValue)
              {
                if (sensor == 2)
                  {
                    mq2Status = 2;
                  }
                else if (sensor == 3)
                  {
                    mq3Status = 2;
                  }
                else if (sensor == 4)
                  {
                    mq4Status = 2;
                  }
                else if (sensor == 5)
                  {
                    mq5Status = 2;
                  }
                else if (sensor == 8)
                  {
                    mq8Status = 2;
                  }
                else if (sensor == 9)
                  {
                    mq9Status = 2;
                  }
              }
            else
              {
                if (sensor == 2)
                  {
                    mq2Status = 0;
                  }
                else if (sensor == 3)
                  {
                    mq3Status = 0;
                  }
                else if (sensor == 4)
                  {
                    mq4Status = 0;
                  }
                else if (sensor == 5)
                  {
                    mq5Status = 0;
                  }
                else if (sensor == 8)
                  {
                    mq8Status = 0;
                  }
                else if (sensor == 9)
                  {
                    mq9Status = 0;
                  }
              }

            previousTime = currentTime;
            
          }
      }
  };

class systemOverride
  {
    private:
    int refreshInterval;
    int sensorValue;
    unsigned long previousTime;

    public:
    systemOverride(int interval)
      {
        refreshInterval = interval;
        sensorValue = 0;
        previousTime = 0;
      }

    void Update()
      {
        unsigned long currentTime = millis();

        if (currentTime - previousTime >= refreshInterval)
          {
            pinMode(overridePin, INPUT);
            sensorValue = digitalRead(overridePin);

            if (sensorValue == 0)
              {
                overrideStatus = 1;
              }
            else
              {
                overrideStatus = 0;
              }
            
            previousTime = currentTime;
          }
      }
  };

class soundAlarm
  {
    private:
    int refreshInterval;
    int warningPin;
    int warningState;
    int alarmPin;
    int alarmState;
    unsigned long previousTime;

    public:
    soundAlarm(int interval, int warning, int alarm)
      {
        refreshInterval = interval;
        
        warningPin = warning;
        pinMode(warningPin, OUTPUT);
        warningState = LOW;
        
        alarmPin = alarm;
        pinMode(alarmPin, OUTPUT);
        alarmState = LOW;
 
        previousTime = 0;
      }

    void Alarm()
      {
        unsigned long currentTime = millis();
        
        if (currentTime - previousTime >= refreshInterval)
          {
            //condition for an alarm
            if (overrideStatus == 1)
              {
                if (alarmState == HIGH)
                  {
                    alarmState = LOW;
                    digitalWrite(alarmPin, alarmState);
                    Serial.print("Override Alarm Off");
                  }
                else if (alarmState == LOW)
                  {
                    alarmState = HIGH;
                    digitalWrite(alarmPin, alarmState);
                    Serial.println("Override Alarm On");
                  }
              }
            else if ((mq2Status == 2) || (mq3Status == 2) || (mq4Status == 2) || (mq5Status == 2) || (mq8Status == 2) || (mq9Status == 2))
              {
                if (alarmState == HIGH)
                  {
                    alarmState = LOW;
                    digitalWrite(alarmPin, alarmState);
                    Serial.println("Alarm Off");
                  }
                else if (alarmState == LOW)
                  {
                    alarmState = HIGH;
                    digitalWrite(alarmPin, alarmState);
                    Serial.println("Alarm On");

                    Serial.print("<MQ2STA");
                    Serial.print(mq2Status);
                    Serial.println(">");
                    Serial.print("<MQ3STA");
                    Serial.print(mq3Status);
                    Serial.println(">");
                    Serial.print("<MQ4STA");
                    Serial.print(mq4Status);
                    Serial.println(">");
                    Serial.print("<MQ5STA");
                    Serial.print(mq5Status);
                    Serial.println(">");
                    Serial.print("<MQ8STA");
                    Serial.print(mq8Status);
                    Serial.println(">");
                    Serial.print("<MQ9STA");
                    Serial.print(mq9Status);
                    Serial.println(">");
                  }
              }
            //condition for a warning
            else if ((mq2Status == 1) || (mq3Status == 1) || (mq4Status == 1) || (mq5Status == 1) || (mq8Status == 1) || (mq9Status == 1))
              {
                if (warningState == HIGH)
                  {
                    warningState = LOW;
                    digitalWrite(warningPin, warningState);
                    Serial.println("Warning Off");
                  }
                else if (warningState == LOW)
                  {
                    warningState = HIGH;
                    digitalWrite(warningPin, warningState);
                    Serial.println("Warning On");

                    Serial.print("<MQ2STA");
                    Serial.print(mq2Status);
                    Serial.println(">");
                    Serial.print("<MQ3STA");
                    Serial.print(mq3Status);
                    Serial.println(">");
                    Serial.print("<MQ4STA");
                    Serial.print(mq4Status);
                    Serial.println(">");
                    Serial.print("<MQ5STA");
                    Serial.print(mq5Status);
                    Serial.println(">");
                    Serial.print("<MQ8STA");
                    Serial.print(mq8Status);
                    Serial.println(">");
                    Serial.print("<MQ9STA");
                    Serial.print(mq9Status);
                    Serial.println(">");
                  }
              }
            else
              {
                alarmState = LOW;
                warningState = LOW;

                Serial.print("<MQ2STA");
                Serial.print(mq2Status);
                Serial.println(">");
                Serial.print("<MQ3STA");
                Serial.print(mq3Status);
                Serial.println(">");
                Serial.print("<MQ4STA");
                Serial.print(mq4Status);
                Serial.println(">");
                Serial.print("<MQ5STA");
                Serial.print(mq5Status);
                Serial.println(">");
                Serial.print("<MQ8STA");
                Serial.print(mq8Status);
                Serial.println(">");
                Serial.print("<MQ9STA");
                Serial.print(mq9Status);
                Serial.println(">");

                digitalWrite(alarmPin, alarmState);
                digitalWrite(warningPin, warningState);
              }    
            previousTime = currentTime;
          }
      }
  };

//setup routines to check the sensors
//Ex: checkSensor sensor name(sensor number, analog pin, refresh rate, normal value)
checkSensor mq2(2, 0, 100);
checkSensor mq3(3, 1, 100);
checkSensor mq4(4, 2, 100);
checkSensor mq5(5, 3, 100);
checkSensor mq8(8, 4, 100);
checkSensor mq9(9, 5, 100);
systemOverride sysOverride(100);

//routine to check the status
soundAlarm sensor(1000, 12, 11);

int sensorValue;
void setup()
{
  //quick delay to let the system come up
  delay(500);

  //turn on an LED to show the system is on
  pinMode (systemStatusPin, OUTPUT);
  digitalWrite(systemStatusPin, HIGH);

  //setup serial comms
  Serial.begin(9600);
  Serial.println("Haynie Research & Development");
  Serial.println("Gas Monitor");
}

void loop()
{
    mq2.Update();
    mq3.Update();
    mq4.Update();
    mq5.Update();
    mq8.Update();
    mq9.Update();
    sysOverride.Update();
    sensor.Alarm();
}
