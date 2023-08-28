 alter TRIGGER Updateuserwallet
ON bookingdetail
AFTER INSERT
AS
BEGIN
	
    UPDATE UserDetail
    SET  WalletAmount-=(select sum(charge) from inserted)
  --  WHERE   UserDetail.UserId IN (SELECT inserted.UserId FROM inserted) 
	where UserDetail.UserId in (select ud.UserId from inserted   join UserDrive dr on inserted.UserMappingId=dr.UserDriveMappingId
	join UserDetail ud on ud.UserId=dr.UserId join  paymentType pt on pt.PaymentId=inserted.PaymentTypeId where pt.PaymentId=1)
END;  