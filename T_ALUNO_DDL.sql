use alunosdb;

CREATE TABLE T_ALUNO(
	id INT auto_increment,
    nome VARCHAR(60) NOT NULL,
    nota1 DOUBLE NOT NULL,
	nota2 DOUBLE NOT NULL,
    media DOUBLE NOT NULL,
    ano YEAR NULL DEFAULT NULL,
    status CHAR(9) NOT NULL,
    CONSTRAINT PK_ALUNO PRIMARY KEY (id)
);

DELIMITER //

CREATE TRIGGER TRG_ANO_ALUNO
BEFORE INSERT ON T_ALUNO
FOR EACH ROW
BEGIN
    IF NEW.ano IS NULL THEN
        SET NEW.ano = year(now());
    END IF;
END//

DELIMITER ;


