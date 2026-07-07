create database test

USE test
DROP TABLE test
create table test
(
id nvarchar(10),
pass nvarchar(50),
hoten nvarchar(50),
Quyen nvarchar(50)
primary key(id)
)
insert into test (id,pass,hoten,Quyen)
VALUES ('admin','123','admin','admin')

CREATE table cauthu
(
soao nvarchar(50),
hoten  nvarchar(50),
ngaysinh date,
quoctich nvarchar(50),
primary key(soao)
)
Create table hlv
(
vaitro nvarchar(50),
hoten nvarchar(20),
ngaysinh date,
gioitinh nvarchar(50),
quoctich nvarchar(50)
primary key(vaitro)
)
