![image](https://github.com/user-attachments/assets/5ce45aeb-09ee-46af-a3c8-f7a090928169)/n
![image](https://github.com/user-attachments/assets/a3d3c158-6d4f-48f1-a5fc-e3923eaaa581)/n
![image](https://github.com/user-attachments/assets/3bf1068c-7704-4d98-abcb-64717d0d1b2a)/n



### **การออกแบบ Class Diagram สำหรับระบบขายเครื่องดื่ม**  

จากรายละเอียดของโปรแกรม เราสามารถออกแบบ **Class Diagram** สำหรับ `Item` ซึ่งเป็นคลาสหลักที่จัดการเกี่ยวกับสต็อกสินค้าและการสั่งซื้อเครื่องดื่มได้ดังนี้:

---

## **1. โครงสร้างของ `Item` Class**
```plaintext
+-------------------+
|      Item        |
+-------------------+
| - BlackCoffee: int |
| - Mocca: int      |
| - Latte: int      |
| - Chocolate: int  |
| - Water: int      |
| - Coffee: int     |
| - ChocolatePowder: int |
| - Milk: int       |
+-------------------+
| + Item(int blackCoffee, int mocca, int latte, int chocolate, int water, int coffee, int chocolatePowder, int milk) |
| + bool BuyBlackCoffee(int amount) |
| + bool BuyMoccaCoffee(int amount) |
| + bool BuyLatteCoffee(int amount) |
| + bool BuyChocolate(int amount) |
| + void IncreaseStock(int blackCoffee, int mocca, int latte, int chocolate, int water, int coffee, int chocolatePowder, int milk) |
| + string GetStockInfo() |
+-------------------+
```
---

## **2. รายละเอียดของคลาส `Item`**
คลาส `Item` ถูกออกแบบให้เป็นตัวแทนของ **สินค้าคงคลัง** และการจัดการวัตถุดิบของร้านกาแฟ โดยมี **แอตทริบิวต์ (Attributes) และเมธอด (Methods)** ดังนี้:

### **แอตทริบิวต์ (Attributes)**
- `BlackCoffee: int` → จำนวนกาแฟดำที่มีอยู่
- `Mocca: int` → จำนวนมอคค่าที่มีอยู่
- `Latte: int` → จำนวนลาเต้ที่มีอยู่
- `Chocolate: int` → จำนวนช็อคโกแลตที่มีอยู่
- `Water: int` → ปริมาณน้ำที่เหลือ
- `Coffee: int` → ปริมาณกาแฟที่เหลือ
- `ChocolatePowder: int` → ปริมาณผงช็อคโกแลตที่เหลือ
- `Milk: int` → ปริมาณนมที่เหลือ

---

### **เมธอด (Methods)**
1. **คอนสตรัคเตอร์**
   ```csharp
   public Item(int blackCoffee, int mocca, int latte, int chocolate, int water, int coffee, int chocolatePowder, int milk)
   ```
   - ใช้สำหรับกำหนดค่าสินค้าคงคลังเริ่มต้น เช่น จำนวนกาแฟ น้ำ นม และผงช็อคโกแลต

2. **เมธอดสำหรับการซื้อเครื่องดื่ม**
   ```csharp
   public bool BuyBlackCoffee(int amount)
   ```
   - ใช้ตรวจสอบว่าสินค้าเพียงพอหรือไม่
   - หากเพียงพอ → ลดสต็อก และคืนค่า `true`
   - หากไม่เพียงพอ → คืนค่า `false`
   
   ***เมธอดอื่น ๆ ที่ทำงานในลักษณะเดียวกัน:***
   - `BuyMoccaCoffee(int amount)`
   - `BuyLatteCoffee(int amount)`
   - `BuyChocolate(int amount)`

3. **เมธอดเพิ่มสต็อกสินค้า**
   ```csharp
   public void IncreaseStock(int blackCoffee, int mocca, int latte, int chocolate, int water, int coffee, int chocolatePowder, int milk)
   ```
   - ใช้สำหรับเติมวัตถุดิบที่ใช้ในการทำเครื่องดื่ม

4. **เมธอดแสดงปริมาณสต็อกคงเหลือ**
   ```csharp
   public string GetStockInfo()
   ```
   - คืนค่าข้อความที่บอก **ปริมาณวัตถุดิบที่เหลืออยู่** เช่น  
     ```
     Water: 398L
     Coffee Powder: 1050g
     Chocolate Powder: 1010g
     Milk: 1000g
     ```

---

## **3. คำอธิบายการออกแบบ**
1. **การใช้ `int` สำหรับปริมาณสินค้า**
   - ค่าจำนวนเต็ม (`int`) ถูกใช้ในการเก็บข้อมูลของสินค้าคงคลัง เช่น จำนวนแก้วหรือกรัมของแต่ละวัตถุดิบ
   - การใช้ `int` แทน `double` ช่วยลดปัญหาทศนิยมที่ไม่จำเป็น เช่น ปริมาณที่ต้องคำนวณจากระบบเมตริก

2. **การใช้ `bool` ในเมธอดซื้อเครื่องดื่ม**
   - เมธอด `BuyBlackCoffee()`, `BuyMoccaCoffee()`, `BuyLatteCoffee()`, `BuyChocolate()` ใช้ `bool` เพื่อแจ้งว่าการซื้อสำเร็จหรือไม่  
   - หากมีสินค้าพอ → คืนค่า `true` และลดจำนวนสินค้า  
   - หากไม่มีสินค้าพอ → คืนค่า `false`

3. **การเพิ่มสต็อก**
   - เมธอด `IncreaseStock()` ใช้เพิ่มสต็อกสินค้า โดยให้ผู้ดูแลร้านสามารถเพิ่มวัตถุดิบได้ง่าย

4. **การแสดงข้อมูลสต็อก**
   - เมธอด `GetStockInfo()` คืนค่าเป็นข้อความที่แสดงจำนวนวัตถุดิบที่เหลืออยู่ เพื่อให้สามารถตรวจสอบสินค้าคงเหลือได้ง่าย

---

## **4. สรุป**
- คลาส `Item` ออกแบบให้เป็น **ศูนย์กลางของระบบคลังสินค้าและการสั่งซื้อ**  
- มีการแยก **วัตถุดิบออกจากเมนูเครื่องดื่ม** เพื่อความยืดหยุ่นในการเพิ่มหรือลดเมนูใหม่ ๆ  
- มี **ระบบจัดการสต็อกสินค้า** ที่สามารถเติมสินค้าและเช็คของคงคลังได้  
- มีการ **แจ้งเตือนเมื่อสินค้าหมด** ผ่านการคืนค่า `false` ในเมธอดซื้อเครื่องดื่ม  

---

### **สามารถเพิ่มเติมอะไรได้อีก?**
- ออกแบบ **GUI** สำหรับเลือกและสั่งซื้อเครื่องดื่ม  
- เพิ่มระบบ **บันทึกยอดขาย** และ **ประวัติการสั่งซื้อ**  
- เพิ่มระบบ **แจ้งเตือนอัตโนมัติ** เมื่อสต็อกวัตถุดิบใกล้หมด  
- ใช้ **Database** ในการจัดเก็บข้อมูลวัตถุดิบ แทนการเก็บไว้ในตัวแปร  

---
