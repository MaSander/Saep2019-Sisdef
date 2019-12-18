USE SISDEF

BULK INSERT TIPO_EQUIPAMENTO
	FROM 'C:\csv\tipo_equipamento.csv'
		WITH(
			FIRSTROW = 1,
			FIELDTERMINATOR = ',',
			ROWTERMINATOR = '\n',
			CODEPAGE = 'ACP',
			DATAFILETYPE = 'Char'
		);

BULK INSERT EQUIPAMENTO
	FROM 'C:\csv\equipamento.csv'
		WITH(
			FIRSTROW = 1,
			FIELDTERMINATOR = ',',
			ROWTERMINATOR = '\n',
			CODEPAGE = 'ACP',
			DATAFILETYPE = 'Char'
		);
		
BULK INSERT DEFEITO
	FROM 'C:\csv\defeito.csv'
		WITH(
			FIRSTROW = 1,
			FIELDTERMINATOR = ',',
			ROWTERMINATOR = '\n',
			CODEPAGE = 'ACP',
			DATAFILETYPE = 'Char'
		);

BULK INSERT REGISTRO_DEFEITO
	FROM 'C:\csv\registro_defeito.csv'
		WITH(
			FIRSTROW = 1,
			FIELDTERMINATOR = ',',
			ROWTERMINATOR = '\n',
			CODEPAGE = 'ACP',
			DATAFILETYPE = 'Char'
		);

INSERT INTO USUARIO(EMAIL, SENHA)
VALUES('admin@email', '12345');













