
create table UserDetail (UserId int primary key,UserName varchar(30),Gender nvarchar(5),WalletAmount int)

create table DriverDetail(DriverId int primary key,DriverName varchar(30),Gender nvarchar(5))

create table UserDrive(UserDriveMappingId int primary key,UserId int foreign key references userdetail(userid)
,PickupLocationId int foreign key references LocationMapping (LocationMappingId) ,
DropLocationId int foreign key references LocationMapping (LocationMappingId),CancelBooking varchar(15)  )

create table DriverLocation (DriverLocationId int primary key,DriverId int foreign key references driverdetail(driverid),
DriverLocation int,Avaliablity varchar(5))

--create table LocationMapping (LocationMappingId int primary key,LocationName varchar(40))

create table paymentType(PaymentId int primary key,PaymentType varchar(30))

create table BookingDetail(BookingId int primary key ,DriverId int foreign key references driverdetail(driverid),
UserMappingId int foreign key references UserDrive(UserDriveMappingId),Charge int,
PaymentTypeId int foreign key references PaymentType(PaymentId) ,BookingTime datetime default getdate())


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
