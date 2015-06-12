USE [academia]
GO
/****** Object:  StoredProcedure [dbo].[spPagoExtra]    Script Date: 11/06/2015 14:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spPagoExtra]
	-- Add the parameters for the stored procedure here
	@idPago int,
	@saldoAnterior int	
AS
BEGIN	
	select pe.balance as saldoFinal ,concat(e.first_name , ' ', e.last_name) as fullname ,p.amount as pago, p.no_document , CONCAT(em.first_name, ' ', em.last_name) as NombreUsuario, tp.description , @saldoAnterior as saldoAnterior
	from extra_payments pe 
	inner join students e on pe.id_student = e.id
	inner join payments p on pe.id_payment = p.id
	inner join payment_types tp on pe.id_type_payment = tp.id
	inner join users u on p.id_user = u.id  
	inner join employees em on u.id_employee = em.id
	where p.id = @idPago;
END