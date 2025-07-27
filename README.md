# ☕ Phần mềm Quản lý Quán Coffee

## 📌 Giới thiệu

Phần mềm được phát triển nhằm hỗ trợ các quán cà phê vừa và nhỏ tự động hóa quy trình quản lý **bàn**, **menu**, **hóa đơn**, **nhân viên** và **thống kê doanh thu**, giúp hạn chế sai sót khi tính toán thủ công, tiết kiệm thời gian và nâng cao hiệu quả kinh doanh.

---

## 🎯 Mục tiêu dự án

* Xây dựng phần mềm **chạy trên nền tảng Windows** với giao diện thân thiện, dễ sử dụng.
* Tích hợp **cơ sở dữ liệu SQL Server** để lưu trữ dữ liệu khách hàng, nhân viên, hóa đơn và sản phẩm.
* Cung cấp **các chức năng quản lý cơ bản và nâng cao**:

  * Quản lý nhân viên và phân quyền.
  * Quản lý bàn, thực đơn, danh mục sản phẩm.
  * Tạo và thanh toán hóa đơn.
  * Thống kê doanh thu và lương nhân viên.
* **Bảo mật**: đăng nhập với phân quyền (Admin/Nhân viên), mã hóa mật khẩu.

---

## 🛠️ Công nghệ sử dụng

* **Ngôn ngữ lập trình:** C# (.NET Framework, Windows Forms)
* **Cơ sở dữ liệu:** Microsoft SQL Server
* **IDE:** Visual Studio 2022
* **Công cụ hỗ trợ phân tích thiết kế:** PowerDesigner, StarUML, WhiteStarUML
* **Thư viện:** LINQ, System.Data.SqlClient
* **Kỹ thuật:**

  * CRUD (Create, Read, Update, Delete) cho quản lý dữ liệu.
  * Phân quyền người dùng.
  * Thống kê và báo cáo (biểu đồ, dữ liệu động).

---

## ⚙️ Chức năng hệ thống

### 1. **Đăng nhập & phân quyền**

* Người dùng đăng nhập bằng tài khoản và mật khẩu.
* **Admin:** quyền quản lý toàn bộ hệ thống.
* **Nhân viên:** chỉ được phép tạo hóa đơn và thanh toán.

### 2. **Quản lý Nhân viên**

* Thêm, sửa, xóa thông tin nhân viên (Họ tên, tài khoản, mật khẩu, vai trò).
* Quản lý ca làm việc, chấm công.
* Quản lý và tính lương nhân viên.

### 3. **Quản lý Bàn**

* Hiển thị danh sách bàn (trống/đang có khách).
* Thêm bàn mới, xóa bàn, cập nhật trạng thái.

### 4. **Quản lý Danh mục & Sản phẩm**

* Thêm, sửa, xóa danh mục đồ uống.
* Thêm, sửa, xóa sản phẩm (Tên, giá, hình ảnh, đơn vị tính).
* Tìm kiếm sản phẩm theo tên hoặc danh mục.

### 5. **Bán hàng & Thanh toán**

* Chọn bàn và sản phẩm để lập hóa đơn.
* Cập nhật số lượng sản phẩm trong hóa đơn.
* Áp dụng giảm giá khi thanh toán.
* Xuất hóa đơn chi tiết cho khách hàng.

### 6. **Quản lý Hóa đơn**

* Xem danh sách hóa đơn theo ngày, tháng, năm.
* Tìm kiếm hóa đơn theo mã hoặc bàn.
* In báo cáo hóa đơn.

### 7. **Thống kê Doanh thu & Lương**

* Thống kê doanh thu theo ngày, tháng, năm.
* Hiển thị doanh thu theo sản phẩm.
* Thống kê lương nhân viên theo ca làm.

---

## 🗃️ Thiết kế Cơ sở dữ liệu

Hệ thống sử dụng các bảng chính:

* **Account**: Thông tin tài khoản (UserName, DisplayName, PassWord, Role, Lương).
* **TableFood**: Quản lý bàn (ID, Tên bàn, Trạng thái).
* **FoodCategory**: Danh mục đồ uống.
* **Food**: Sản phẩm (Tên, Giá, Hình ảnh, Danh mục).
* **Bill**: Hóa đơn (Ngày vào, Ngày ra, Tổng tiền, Giảm giá, ID bàn).
* **BillInfo**: Chi tiết hóa đơn (Số lượng món, Giá).
* **TimeKeeping**: Chấm công nhân viên.

---

## 📐 Thiết kế hệ thống

Hệ thống được phân tích và thiết kế theo mô hình UML:

* **Biểu đồ Use Case**: Xác định vai trò và chức năng của Khách hàng, Nhân viên, Admin.
* **Sơ đồ ERD (Entity Relationship Diagram)**: Mô tả quan hệ giữa các bảng.
* **Sơ đồ DFD (Data Flow Diagram)**: Luồng xử lý từ đặt hàng → thanh toán → lưu hóa đơn → thống kê.
* **Sơ đồ BPMN**: Mô tả quy trình nghiệp vụ.

---

## 🖥️ Giao diện phần mềm

### Giao diện Admin:

* Đăng nhập & Trang chủ.
* Quản lý nhân viên (thêm, sửa, xóa, tìm kiếm).
* Quản lý sản phẩm và danh mục.
* Quản lý bàn.
* Thống kê doanh thu, lương nhân viên.
* Quản lý hóa đơn.

### Giao diện Nhân viên:

* Đăng nhập ca làm.
* Xem bàn, chọn món, lập hóa đơn.
* Thanh toán và in hóa đơn cho khách hàng.

---

## 🔐 Bảo mật

* **Phân quyền người dùng:** Admin và Nhân viên.
* **Mã hóa mật khẩu:** Sử dụng kỹ thuật mã hóa trước khi lưu vào cơ sở dữ liệu.
* **Quản lý phiên đăng nhập:** Lưu lại lịch sử đăng nhập/đăng xuất của nhân viên.

---

## 📊 Thống kê & Báo cáo

* Doanh thu theo từng tháng.
* Biểu đồ doanh thu theo danh mục sản phẩm.
* Thống kê lương nhân viên, số ca làm việc.
* Báo cáo hóa đơn chi tiết.

---

## ✅ Kết luận

Hệ thống giúp:

* **Tự động hóa quy trình quản lý quán cà phê.**
* **Tiết kiệm thời gian, giảm sai sót, tăng tính chuyên nghiệp.**
* **Có khả năng triển khai thực tế cho các quán vừa và nhỏ.**

---

## 🚀 Hướng dẫn cài đặt & sử dụng

### 1. Yêu cầu hệ thống

* **Hệ điều hành:** Windows 7/8/10/11 (64-bit)
* **.NET Framework:** Phiên bản ≥ 4.7.2
* **SQL Server:** 2014 trở lên (khuyến nghị SQL Server 2019)
* **Visual Studio:** 2019 hoặc 2022 (nếu muốn mở mã nguồn)
* **Dung lượng ổ cứng:** ≥ 500 MB trống
* **RAM:** ≥ 4 GB

---

### 2. Các bước cài đặt

#### 🔹 2.1. Cài đặt cơ sở dữ liệu

1. Mở **SQL Server Management Studio (SSMS)**.
2. Tạo một **database mới** với tên ví dụ: `CoffeeShopDB`.
3. Import file `.sql` (đi kèm trong thư mục `Database/`) để khởi tạo bảng (`Account`, `Bill`, `Food`, `TableFood`, ...).
4. Kiểm tra dữ liệu mẫu:

   ```sql
   SELECT * FROM Account;
   SELECT * FROM Food;
   ```

#### 🔹 2.2. Cấu hình ứng dụng

1. Mở file **App.config** hoặc phần kết nối trong code:

   ```xml
   <connectionStrings>
       <add name="CoffeeShopConnectionString"
            connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=CoffeeShopDB;Integrated Security=True"/>
   </connectionStrings>
   ```
2. Thay `YOUR_SERVER_NAME` bằng tên máy chủ SQL của bạn.

#### 🔹 2.3. Build & chạy ứng dụng

* Nếu dùng **Visual Studio**:

  * Mở project `.sln`.
  * Nhấn **Build > Rebuild Solution**.
  * Chạy bằng nút **Start (F5)**.
* Nếu có file `.exe`:

  * Mở thư mục `Release/` hoặc `bin/Debug/`.
  * Chạy **CoffeeShop.exe**.

---

### 3. Hướng dẫn sử dụng

#### 🔹 3.1. Đăng nhập

* **Admin:**

  * Username: `admin`
  * Password: `admin`
* **Nhân viên (sample):**

  * Username: `staff01`
  * Password: `123456`

#### 🔹 3.2. Dành cho Admin

* Quản lý nhân viên, bàn, menu, hóa đơn.
* Xem báo cáo doanh thu, lương.
* Thêm sản phẩm mới:

  * Vào **Menu → Quản lý Sản phẩm → Thêm**.
* Xem thống kê:

  * **Menu → Thống kê → Doanh thu theo tháng**.

#### 🔹 3.3. Dành cho Nhân viên

* Đăng nhập → Chọn bàn → Chọn món → Xác nhận đơn.
* Khi khách thanh toán:

  * Nhấn **Thanh toán → Xuất hóa đơn**.
* Trường hợp khách hủy:

  * Nhấn **Hủy hóa đơn**.

---

### 4. Lưu ý bảo mật

* **Thay đổi mật khẩu mặc định** sau khi cài đặt.
* **Giới hạn quyền nhân viên**: chỉ được phép tạo hóa đơn, không được xóa/sửa sản phẩm.
* **Sao lưu database định kỳ** để tránh mất dữ liệu.



