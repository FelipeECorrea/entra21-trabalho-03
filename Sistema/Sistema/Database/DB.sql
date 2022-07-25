CREATE TABLE unidades_federativas (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	sigla VARCHAR(2)
);

CREATE TABLE cidades (
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_unidade_federativa INTEGER, -- FK

	nome VARCHAR(50),
	populacao INTEGER,
	data_criacao DATETIME2,
	pib DECIMAL(6,2),

	FOREIGN KEY(id_unidade_federativa) REFERENCES unidades_federativas(id)
);


SELECT * FROM unidades_federativas;
SELECT * FROM cidades;


INSERT INTO cidades (id_unidade_federativa, nome, populacao, data_criacao, pib) VALUES
(2,'Blumenau',21,'2022-07-10',1);