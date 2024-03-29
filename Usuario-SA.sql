SELECT name, type_desc, is_disabled 
FROM sys.server_principals 
WHERE name = 'sa';

SELECT permission_name, state_desc 
FROM sys.server_permissions 
WHERE grantee_principal_id = (SELECT principal_id FROM sys.server_principals WHERE name = 'sa');

**para verificar as permissões de servidor para o login 'sa'**
SELECT * FROM sys.server_permissions WHERE grantee_principal_id = (SELECT principal_id FROM sys.server_principals WHERE name = 'sa');

**para verificar as permissões de banco de dados para o usuário associado ao login 'sa'**
SELECT * FROM sys.database_permissions WHERE grantee_principal_id = (SELECT principal_id FROM sys.server_principals WHERE name = 'sa');

ALTER LOGIN sa ENABLE;