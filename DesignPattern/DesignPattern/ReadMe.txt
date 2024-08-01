There is have 3 main categories design pattern base on 3 problem areas:
	- Creational Design Pattern (Object Creation and Initialization)
	- Structural Design Pattern (Structural Changes of Classes, and Interfaces, and the Relationship Between Classes)
	- Behavioral Design Pattern (Communication Between Objects)


1. Creational Design Pattern: Trong thực thế, các dự án có rất nhiều class, object. Và các class, object liên kết với nhau. vì thế khi chúng ta sử dụng phải khởi tạo rất nhiều đối tượng rất nhiều
( like new Product(), new Category(), new Invoice(), new Payment().. ). Vì thế nếu không dc tập trung và quản lí sẽ đưa đến các vấn đề sau này phức tạo ==> Creational Design Pattern ra đời

2. Structural Design Pattern: Trong dự án các object and class có các mối quan hệ liên kết với nhau. vd như user and product, 1 user có nhiều product với qan hệ one - many. 
Sau này chúng ta muốn user và product độc lập với nhau, vì vậy loại bỏ mối qan hệ giữa chúng, nhưng lại không muốn thay đổi cấu trúc của project ==> Structural Design Pattern ra đời

3. Behavioral Design Pattern: Là các thiết kế, xử lí việc giao tiếp, tương tác giữa các class và object. Mục tiêu là đảm bảo việc giao tiếp giữa chúng hiệu quả nhưng các class và object
vẫn không ràng buộc vào nhau. Điều đó làm cho hệ thống linh hoạt và dễ dàng mở rộng cũng như quản lí