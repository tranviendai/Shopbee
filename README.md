# Shopbee
-> Download .net core MVC 7.0 (framework)
Mở app -> Tools -> Nutget Packet ... -> Packet Manager Console 
Cmd: "update-database" để có phần dữ liệu trên máy cá nhân
Thay đổi: file appsettings.json -> tìm dòng "JZenoContext": "Server=MYSQLNAME" hãy để ý chỗ Server để nó trùng với tên Server của SQL của máy chính chủ
- Update Project (1/11/2023):
+ Đã hoàn thành:
   BE: phân quyền tất cả view and controller, data (80-90%) ok
   FE: Home, Partner, Category, News, Product, Profile, Login, Register, Statistics,... (có search and filter ở Home và các trang Manage)
+ Chưa hoàn thành:
   BE: data phần comment sản phẩm, và các phần lẻ tẻ như viewer của 1 sản phẩm, countProduct khi được bán
   FE: productComment, cải thiện search và filter cho tất cả Views, cập nhật lại Statistics cho từng Partner, giao diện chưa được tốt lắm cần chỉnh sửa lại sau lần update tiếp theo...

-> Lưu ý: các file nằm trong folder images cần đc cố định như lần đầu (ví dụ: đã có 12 file imgName.png cùng tên vs data ở JZenoDbContext thì cũng phải giữ nguyên file đó, mục đích là mỗi lần update-database sẽ có hình ảnh cho mọi người)
