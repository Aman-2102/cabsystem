create trigger updatedriver
on bookingdetail
AFTER INSERT
AS
BEGIN
update DriverLocation set Avaliablity='no' 
 WHERE   DriverLocation.Avaliablity ='yes' and DriverId in (select inserted.driverid from inserted)
 end

