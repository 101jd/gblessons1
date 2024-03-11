import cv2

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml")

img = cv2.imread("gos.jpg")
#print(img.shape)
img = cv2.resize(img, (500, 500))
#print(img.shape)
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

faces = face_cascades.detectMultiScale(gray)
# print(faces) #координаты, длина, ширина лица

for (x, y, w, h) in faces:
    cv2.rectangle(img, (x, y), (x + w, y + h), (255, 0, 255), 1)

cv2.imshow("Poyebat", img)
cv2.waitKey(0)



