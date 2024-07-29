-- to create a new database
create database db_apple;

--to create a new database table in existing table
use db_apple;
create table tbl_students
(
    roll int primary key identity(1, 1),
    fname varchar(200) not null,
    lname varchar(200) not null,
    smarks int not null,
    sdob date not null
);

-- to insert a piece of information into database table with table fields : Method 1
use db_apple;
insert into tbl_students (fname,lname,smarks,sdob) values ('Ram','Pokhara',45,'1999-02-14');

use db_apple;
select * from tbl_students

use db_apple;
insert into tbl_students values ('Sita','pokhara',55,'2000-02-22');

use db_apple;
insert into tbl_students values
('laxman', 'joshi', '88', '2000-01-01'),
('bharat', 'joshi', '89', '2017-03-10'),
('gita', 'bhatt', '78', '2015-01-10'),
('rita', 'shrestha', '55', '2013-02-01');ṇ