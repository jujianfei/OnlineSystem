---- �������ݿ�
--create database newssystem
---- ��������
--create table category
--(
--	id int identity(1,1) primary key,
--	[name] varchar(20) not null
--)
---- �������ű�
--create table news
--(
--	id int identity(1,1) primary key,
--	title varchar(100) not null,
--	[content] text not null,
--	createTime datetime not null,
--	caId int 
--)
---- �������۱�
--create table comment
--(
--	id int identity(1,1) primary key,
--	[content] text not null,
--	createTime datetime not null,
--	userIp varchar(15) not null,
--	newsId int
--)
select * from category
insert into category(name) values('��������c')delete category where id=4--')
select * from category where [name]='�й�����'
delete from category where id=5
update category set [name]='B2C' where id=20

select * from news
insert into news()

select * from comment where newsId=4
insert into comment([content],userIp, newsId) values('aaaaa','127.0.0.1',4)
delete comment where id=2