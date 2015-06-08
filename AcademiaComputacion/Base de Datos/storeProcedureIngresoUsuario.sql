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