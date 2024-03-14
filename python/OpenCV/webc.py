import cv2
import numpy as np

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_eye.xml")



cap = cv2.VideoCapture(0)

while True:
    _, frame = cap.read()
    #cv2.imshow("camera 0", frame)
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascades.detectMultiScale(gray)
    
    for (x, y, w, h) in faces:
        cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 255), 2)
    
    cv2.imshow("camera 0", frame)
    if cv2.waitKey(1) & 0xff == ord('q'):
        break
    
