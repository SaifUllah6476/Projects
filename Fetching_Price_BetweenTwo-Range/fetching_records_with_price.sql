create database fetching_records_with_price
use fetching_records_with_price

create table tbl_product
(
pro_id int primary key identity,
Pro_Company nvarchar(50) not null,
Pro_Name nvarchar(50) not null,
Pro_Descripton nvarchar(50) not null,
Pro_Price int
)

select * from tbl_product
insert into tbl_product values ('Nestle','DairyMilk','Sweet, Soft and Testy', 100)
insert into tbl_product values ('Nestle','Water','Pure with Minerals', 200)
insert into tbl_product values ('Nestle','Nido','Healthy Milk', 800)
insert into tbl_product values ('Nestle','Everyday','Milk for Tea', 600)
insert into tbl_product values ('Nestle','Milo','chocolate-flavoured malted powder milk', 400)



create proc pro_details
(
@start int,
@end int

)
as
begin
select * from tbl_product where Pro_Price between @start and @end
end
