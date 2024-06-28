Ajustes realizados :

* Ajuste do nome da model pois estava ambigua com o mesmo nome de uma propriedade default do C#
* Inclusão dos pacotes do entity pois não estavam instalados no projeto
* Criação da Interface Repository pois não existia no projeto
* Inclusão de DataAnnotations para a model de task
* Injeção de depêndencia da classe repository na program
* Inclusão de docker-compose para poder rodar uma instancia do sql 
* inclusão da connection string e conexão na classe program
* inclusão de uma nova classe baseEntity para poder criar o Id sequencialmente no banco e não aparecer o Id no json de request
* Estrutura de pasta alterada para que agora tenhamos uma pasta apenas de interfaces (repositories, services)
* Inclusão de Log´s para poder acompanhar passo a passo da aplicação e saber o que está acontecendo.
