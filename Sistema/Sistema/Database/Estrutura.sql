CREATE TABLE torneios (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(25),
	modo_jogo VARCHAR(50),
	modo_presencial VARCHAR(50),
	data_inicio DATETIME2,
	data_termino DATETIME2,
	categoria VARCHAR(20),
	premiacao VARCHAR(100));

INSERT INTO torneios VALUES
	('BLAST', '5x5', 'Sim', '2022-08-15', '2022-09-01', '', '750.000 - 1.000.000'),
	('ESL', '5x5', 'Sim', '2022-10-10', '2022-11-01', '', '750.000 - 1.000.000');

CREATE TABLE transmissoes (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_torneio INTEGER,
	nome_live VARCHAR(50),
	nome_narrador VARCHAR(50),
	plataforma VARCHAR(25),
	idioma_portugues BIT,
	idioma_ingles BIT,
	idioma_espanhol BIT,

	FOREIGN KEY(id_torneio) REFERENCES torneios(id));

INSERT INTO transmissoes VALUES
	('1', 'Gaules', 'Alexandre', 'Twitch', '1', '0', '0'),
	('2', 'Gaules', 'Alexandre', 'Twitch', '1', '0', '0');

CREATE TABLE times (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(25),
	nacionalidade VARCHAR(20),
	data_criacao DATETIME2);

INSERT INTO times VALUES
	('Lg', 'Brasil', '2004-05-10'),
	('Sk', 'Brasil', '2003-04-10'),
	('Furia', 'Brasil', '2007-04-10'),
	('Imperial', 'Brasil', '2022-05-29');

CREATE TABLE jogadores (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_time INTEGER,
	nick VARCHAR(25),
	email VARCHAR(70),
	senha VARCHAR(50),
	patente VARCHAR(25),
	
	FOREIGN KEY(id_time) REFERENCES times(id));

INSERT INTO jogadores VALUES
	('1', 'João', 'João@gmail.com', '123', 'global'),
	('1', 'Amanda', 'Amanda@gmail.com', '456', 'global'),
	('1', 'Perez', 'Perez@gmail.com', '789', 'global'),
	('1', 'Gustavo', 'Gustavo@gmail.com', '123', 'global'),
	('1', 'Juliana', 'Juliana@gmail.com', '456', 'global'),
	('2', 'Leo', 'Leo@gmail.com', '789', 'global'),
	('2', 'Kauã', 'Kauã@gmail.com', '123', 'global'),
	('2', 'Claudio', 'Claudio@gmail.com', '456', 'global'),
	('2', 'Douglas', 'Douglas@gmail.com', '789', 'global'),
	('2', 'Francisco', 'Francisco@gmail.com', '123', 'global'),
	('3', 'Felipe', 'Felipe@gmail.com', '456', 'global'),
	('3', 'Wellinton', 'Wellinton@gmail.com', '789', 'global'),
	('3', 'Grilo', 'Grilo@gmail.com', '123', 'global'),
	('3', 'Clara', 'Clara@gmail.com', '456', 'global'),
	('3', 'Calabresa', 'Calabresa@gmail.com', '789', 'global'),
	('4', 'Fer', 'fergod@gmail.com', 'bigd', 'global'),
	('4', 'Fnx', 'linconlau@gmail.com', '3mundiais', 'global'),
	('4', 'Fallen', 'fallen@gmail.com', 'awpgod', 'global'),
	('4', 'Vini', 'vini@gmail.com', '12345', 'global'),
	('4', 'Boltz', 'NigelFilmeRio@gmail.com', 'ak47', 'global');

CREATE TABLE grupos (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_time INTEGER,
	id_torneio INTEGER,

	FOREIGN KEY(id_time) REFERENCES times(id),
	FOREIGN KEY(id_torneio) REFERENCES torneios(id));

CREATE TABLE partidas (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	partida_escolhida VARCHAR(100),
	mapa_1 VARCHAR(25),
	mapa_2 VARCHAR(25),
	mapa_3 VARCHAR(25));
	
CREATE TABLE contas (
	id INT PRIMARY KEY IDENTITY(1,1),
	usuario VARCHAR(25) NOT NULL,
	email VARCHAR(50) NOT NULL,
	senha VARCHAR(20) NOT NULL
);
INSERT INTO contas VALUES
	('Felipe Corrêa','pessoal.fec@gmail.com', '2022'),
	('Juliana Forbici','juliana@gmail.com', '2022'),
	('Kaua Amaral','kaua@gmail.com', '2022');

SELECT * FROM contas;
SELECT * FROM torneios;
SELECT * FROM times;
SELECT * FROM transmissoes;
SELECT * FROM grupos;
SELECT * FROM partidas;
SELECT * FROM jogadores;