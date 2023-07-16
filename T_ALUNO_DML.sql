USE alunosdb;

INSERT INTO T_ALUNO (nome, nota1, nota2, media, ano, status)
VALUES ('João', 5, 10, (5 + 10) / 2, 2022, 'Aprovado'), 
		('João', 7, 5, (7 + 5) / 2, null, 'Reprovado'), 
        ('Carlos', 3, 7, (3 + 7) / 2, 2022, 'Reprovado'),
		('João', 2, 10, (2 + 10) / 2, null, 'Reprovado'),
        ('Vinicius', 4.5, 6, (4.5 + 6) / 2, 2022, 'Reprovado'),
		('Vinicius', 3.1, 7.7, (3.1 + 7.7) / 2, 2022, 'Reprovado');