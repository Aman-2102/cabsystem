 alter TRIGGER Updateuserwallet
ON bookingdetail
after INSERT
AS
BEGIN

	declare @userid int ,@charge int
    UPDATE UserDetail
    SET  WalletAmount-=(select charge from inserted)
    WHERE   UserDetail.UserId IN (SELECT inserted.UserId FROM inserted) 
  
	select @userid=userid,@charge=charge from inserted
	insert into HistoryRecord values('booking id is '+cast(@userid as nvarchar(5)) +'  charged   '+cast(@charge as varchar) +'  updated  on   '+CAST(GETDATE() as nvarchar(30)) )

END;  
create trigger updatedriver
on bookingdetail
after INSERT
AS
BEGIN
update DriverLocation set Avaliablity='no' 
 WHERE   DriverLocation.Avaliablity ='yes' and
 DriverId in (select inserted.driverid from inserted)
 end
 