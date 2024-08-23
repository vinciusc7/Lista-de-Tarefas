Para executar a aplicação backend, não é necessário executar nenhum script SQL para construção do banco de dados.

Utilizando o método this.Database.EnsureCreated(); minha aplicação se torna responsável por constuir o banco de dados desde que a connectionString esteja bem configurada:

![image](https://github.com/user-attachments/assets/811e45ca-e891-44df-961f-5489e15d95ec)

O backend está rodando na porta 7727 pelo visual studios e pelo .exe na porta padrão 5001. Já o front na porta 4200

Agora é possivel rodar a aplicação no docker, onde ela está sendo orquestrada pelo docker-compose:
![image](https://github.com/user-attachments/assets/283e9584-509d-433d-a248-fc3eacbf035b)

Obrigado por analisarem meu código!
