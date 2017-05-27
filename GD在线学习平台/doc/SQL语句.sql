---- 建立数据库
--create database newssystem
---- 建立类别表
--create table category
--(
--	id int identity(1,1) primary key,
--	[name] varchar(20) not null
--)
---- 建立新闻表
--create table news
--(
--	id int identity(1,1) primary key,
--	title varchar(100) not null,
--	[content] text not null,
--	createTime datetime not null,
--	caId int 
--)
---- 建立评论表
--create table comment
--(
--	id int identity(1,1) primary key,
--	[content] text not null,
--	createTime datetime not null,
--	userIp varchar(15) not null,
--	newsId int
--)
select * from category
insert into category(name) values('娱乐新闻c')delete category where id=4--')
select * from category where [name]='中国新闻'
delete from category where id=5
update category set [name]='B2C' where id=20

select * from news
insert into news()

select * from comment where newsId=4
insert into comment([content],userIp, newsId) values('aaaaa','127.0.0.1',4)
delete comment where id=2