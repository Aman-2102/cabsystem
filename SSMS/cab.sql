
create table UserDetail (UserId int identity(1,1),UserName varchar(30),Gender nvarchar(5),WalletAmount int)

create table DriverDetail(DriverId int identity(201,1),DriverName varchar(30),Gender nvarchar(5))

create table UserDrive(UserDriveMappingId int identity(301,1),UserId int,PickupLocationId int,DropLocationId int)

create table DriverLocation (DriverId int,DriverLocation int,Avaliablity varchar(5))

create table LocationMapping(LocationMappingId int identity(501,1),LocationName varchar(40))

create table BookingDetail(BookingId int identity(1001,1),UserId int,DriverId int,PickupLocationId int
,DropLocationId int ,Charge int)
insert into UserDetail values('pankaj','M',700)
insert into DriverDetail values('piyush','M')
insert into UserDrive values(4,501,502)
insert into DriverLocation values(205,502,'yes')
insert into LocationMapping values('vastrapur')
select * from DriverDetail
select * from LocationMapping
select * from DriverLocation
select * from UserDrive
select * from UserDetail
select * from BookingDetail
insert into BookingDetail(UserId,DriverId,PickupLocationId,DropLocationId)
select ud.UserId,dd.DriverId,ud.PickupLocationId,ud.DropLocationId from UserDrive ud 
cross join DriverLocation dd where ud.PickupLocationId=dd.DriverLocation
and dd.Avaliablity='yes'

insert into BookingDetail values(4,202,502,503,300)
update DriverLocation set Avaliablity='yes' where Avaliablity='no'
truncate table bookingdetail
update UserDetail set WalletAmount=700 where UserId=4
create table HistoryRecord (historyid int identity(1,1), describe varchar(100))
select * from HistoryRecord