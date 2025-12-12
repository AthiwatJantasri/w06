# Homework 06 – Object-Oriented Programming (OOP)

โปรเจกต์นี้เป็นการบ้านครั้งที่ 6 วิชา **การเขียนโปรแกรมคอมพิวเตอร์เชิงวัตถุ**  
ภาคเรียน 2568-2 สาขาวิทยาการคอมพิวเตอร์

---

## 📂 โครงสร้างโปรเจกต์

w06/ ├── clothes/ │ └── Shirt.java / Shirt.cs / Shirt.cpp / Shirt.py ├── geometry/ │ ├── Earth.java / Earth.cs / Earth.cpp / Earth.py │ ├── Circle.java / Circle.cs / Circle.cpp / Circle.py │ ├── Cylinder.java / Cylinder.cs / Cylinder.cpp / Cylinder.py │ └── Rectangle.java / Rectangle.cs / Rectangle.cpp / Rectangle.py └── main.java / Program.cs / main.cpp / main.py

---

## 🧥 ส่วนที่ 1: Class Shirt และ Enum

- คลาส `Shirt` อยู่ใน package/namespace `clothes`
- มี attributes แบบ private: `color`, `size`, `price`
- `color` และ `size` ใช้ชนิดข้อมูลจาก `enum`
- มี constructor 2 แบบ:
  - แบบรับ parameter ครบทุกตัว
  - แบบไม่มี parameter (default) โดยเรียก constructor แรก
- มี getter/setter สำหรับทุก attributes
- มี method `printInfo()` สำหรับแสดงผล
- มีการสร้าง instance เพื่อทดสอบการใช้งาน

---

## 🌍 ส่วนที่ 2: Geometry Classes

- คลาส `Earth` มีค่าคงที่: `G`, `RADIUS`, `MASS`
- คลาส `Circle`
  - attribute: `radius`
  - method: `area()`, `printInfo()`
- คลาส `Cylinder`
  - attributes: `radius`, `length`
  - method: `area()`, `volume()`, `printInfo()`
- คลาส `Rectangle`
  - attributes: `width`, `height`
  - method: `area()`, `printInfo()`

---

## ✅ วิธีการรัน

### Java
```bash
javac clothes/Shirt.java geometry/*.java Main.java
java Main

📌 หมายเหตุ
โค้ดทุกภาษาเขียนตามหลักการ Encapsulation และ OOP

มีการใช้ enum, constructor, getter/setter, และ method ตามโจทย์ PDF

UML Diagram แนบในรายงานประกอบ
