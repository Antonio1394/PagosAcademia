USE [Academia]
GO
/****** Object:  StoredProcedure [dbo].[IngresoUsuario]    Script Date: 22/05/15 14:17:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[IngresoUsuario]
@user varchar(50),
@password varchar(50),
@tipo varchar(25),
@idEmpleado integer

as
begin
insert into users(
	username,
	password,
	type,
	id_employee,
	state,
	created_at,
	updated_at
					)
values(
	@user,
	@password,
	@tipo,
	@idEmpleado,
	'activo',
	GETDATE(),
	GETDATE()

)
end