USE [academia]
GO
/****** Object:  StoredProcedure [dbo].[spMensualidad]    Script Date: 11/06/2015 14:45:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spMensualidad]
	-- Add the parameters for the stored procedure here
	@idShare int,
	@mes varchar(45)
as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select s.amount, s.date_share , p.description , p.amount , p.no_document, concat(e.first_name , ' ', e.last_name) as fullname , CONCAT(em.first_name, ' ', em.last_name) as NombreUsuario , @mes as Mespagado
	from shares s 
	inner join inscripcions i on s.id_inscripcion = i.id 
	inner join payments p on s.id_payment = p.id 
	inner join students e on p.id_student = e.id 
	inner join users u on p.id_user = u.id  
	inner join employees em on u.id_employee = em.id
	where s.id = @idShare;

END
