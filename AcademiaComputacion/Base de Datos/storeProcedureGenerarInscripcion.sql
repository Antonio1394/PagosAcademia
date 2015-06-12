USE [academia]
GO
/****** Object:  StoredProcedure [dbo].[spIncripcion]    Script Date: 11/06/2015 14:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIncripcion]
@idInscripcion int
as
	select CONCAT(e.first_name, ' ', e.last_name) as NombreAlumno ,p.description,p.amount,p.no_document, g.schedule,g.day , CONCAT(em.first_name, ' ', em.last_name) as NombreUsuario 
	from inscripcions i inner join payments p on i.id_payment = p.id 
	inner join groups g on i.id_group = g.id
	inner join users u on p.id_user = u.id  
	inner join employees em on u.id_employee = em.id
	inner join students e on p.id_student = e.id
	where i.id = @idInscripcion;
