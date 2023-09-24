# Shopbee
-> Download .net core MVC 7.0 (framework)
Mở app -> Tools -> Nutget Packet ... -> Packet Manager Console 
Cmd: "update-database" để có phần dữ liệu trên máy cá nhân

Firt-Code (24-9-2023): 
Back-end:
1. Quản lý authen: signup/signin (tích hợp API gg), thay đổi thông tin cá nhân (mật khẩu, email, họ tên,...)
2. Quản lý đối tác: ứng tuyển trở thành đối tác (với khách hàng) - xác nhận đối tác cho upload sản phẩm lên web (admin)
3. Quản lý sản phẩm: CRUD (đối với đối tác) - thêm category, color, size, quantity,.. xác nhận publish sản phẩm lên web (admin)
4. Quản lý role: CRUD and gán role
5. Đặt hàng + thanh toán: CRUD giỏ hàng, thanh toán online (paypal) và offline (đối với khách hàng)
6. Quản lý comment, tin tức: Chưa làm

Front-end:
1. Quản lý authen, đối tác, role, sản phẩm, đặt hàng, thanh toán (format lại giao diện)
2. Đặt hàng (xử lý logic đặt theo màu+size và giảm số lượng của sản phẩm tương ứng khi đặt thành công)
3. Chỉnh sửa lại giao diện trang chủ và thêm trang chi tiết sản phẩm (có những xử lý event cần thiết)
4. Xử lý ngôn ngữ thành tiếng việt + Xử lý validation các field (text-input)
5. Có thể thêm các controller khác nếu cần thiết nha :>
6. Sau khi BE hoàn thành ở mục 6, thì format giao diện lại lần nữa

Data + Word:
+ Data: mở source > JZenoApp > Data > JZenoDbContext.cs
1. Thêm các user (đối tác, khách hàng) ```` mỗi thứ 4 là đc ````
2. Thêm category (các mục khác như là điện thoại, mỹ phẩm,... kiếm cả hình ảnh nha) ```` Khoảng 3-4 cái nữa````
3. Thêm product (image,color,size,...)  -> cái này lên shopee copy cho lẹ nha :>  ````Khoảng 20 cái nữa````
4. Thêm Voucher (vài cái tượng trưng thôi) ```` 3-4 cái là đc````
5. Thêm Bill, chi tiết đặt hàng ````(5-10 bill là đc rồi)````
6. sau khi mục 6 ở phẩn BE xong thì ngồi thêm nữa nha :>
+ Word: cả nhóm cùng làm, tới đâu tính tới đó hehe :)))
