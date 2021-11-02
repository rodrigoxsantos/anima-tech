<!-- @format -->

# Ânima Tech T2 - GIT

## Comandos Básicos de GIT

O comando git config  é usado para definir valores de configuração específicos do usuário como e-mail, algoritmo preferido para diff, nome de usuário e formato de arquivo etc. exemplo, usando o comando pode para definir email:


```sh
git config --global rodrigo@google.com
```

Comando usado para criar um novo repositório GIT.



```sh
git init
```

Comando usado para adicionar arquivos ao índice.

```sh
git add temp.txt
```

O comando git clone é usado para fins de verificação de repositório. Se o repositório estiver em um servidor remoto, use:

```sh
git clone ssh://rodrigo@example.com/path/to/my-project.git
```

Por outro lado, se uma cópia de trabalho de um repositório local for criada, use:

```sh
git clone /path/to/repository
```

O comando `git commit` é usado para confirmar as alterações na cabeça.

```sh
git commit –m “coloque sua mensagem aqui”
```



O comando `git status `exibe a lista de arquivos alterados juntamente com os arquivos que ainda não foram adicionados ou confirmados.

```sh
git status
```

O Comando git push envia as alterações feitas para o ramo mestre do repositório remoto associado ao diretório de trabalho. Por exemplo:

```sh
git push origin master
```

O comando `git checkout` pode ser usado para criar ramos ou alternar entre eles. Por exemplo, o seguinte cria um novo ramo e muda para ele:

```sh
git checkout -b <branch-name>
```

Para simplesmente mudar de um ramo para outro, use:

```sh
git checkout <branch-name>
```

O comando `git remote` permite que um usuário se conecte a um repositório remoto.

```sh
git remote
```



O comando a seguir lista os repositórios remotos atualmente configurados:

```sh
g`it remote –v
```

Esse comando permite que o usuário se conecte a um servidor remoto:

```sh
git remote add origin <93.169.160.58>
```

O comando `git branch` pode ser usado para listar, criar ou excluir ramos. Para listar todos os ramos presentes no repositório, use:

```sh
git branch
```

Para excluir um ramo:


```sh
git branch –d <branch-name>
```

Para mesclar todas as alterações presentes no repositório remoto para o diretório de trabalho local, o comando pull é usado.

```sh
git pull
```

O comando git merge é usado para mesclar uma ramificação no ramo ativo.

```sh
git merge <branch-name>
```

O comando git diff é usado para listar os conflitos.

```sh
git diff
```


Para visualizar conflitos com o arquivo base, use:

```sh
git diff --base <file-name>
```

O seguinte comando é usado para exibir os conflitos entre ramos about-to-be-merged antes de mesclá-los:

```sh
git diff <source-branch> <target-branch>
```

A marcação é usada para marcar compromissos específicos com alças simples. Um exemplo pode ser:

```sh
git tag 1.1.0 <insert-commitID-here>
```


Executar o comando `git log` exibe uma lista de compromissos em uma ramificação, juntamente com os detalhes pertinentes. Um exemplo de saída pode ser:

```sh
git log
```
commit 15f4b6c44b3c8344caasdac9e4be13246e21sadw
Author: Rodrigo <rodrigo@gmail.com>
Date: Mon Oct 1 23:56:29 2021 -10-08

Para redefinir o índice e o diretório de trabalho para o estado do último commit, o comando `git reset` é usado.

```sh
git reset --hard HEAD
```

O comando `git rm` pode ser usado para remover arquivos do índice e do diretório de trabalho. Uso:

```sh
git rm filename.txt
```

O comando `git stash` é que ajuda a salvar as mudanças que não devem ser cometidos imediatamente, mas em uma base temporária.

```sh
git stash
```

Para visualizar informações sobre qualquer objeto git, use o comando git show. Por exemplo:

```sh
git show
```

O comando `git fetch` permite que um usuário obtenha todos os objetos do repositório remoto que atualmente não residem no diretório de trabalho local. Exemplo de uso:

```sh
git fetch origin
```

Para exibir um objeto de árvore juntamente com o nome e o modo de cada item e o valor SHA-1 do blob, use o comando git ls-tree. Por exemplo:

```sh
git ls-tree HEAD
```

Usando o valor SHA-1, exiba o tipo de um objeto usando o comando git cat-file. Por exemplo:

```sh
git cat-file –p d670460b4b4aece5915caf5c68d12f560a9fe3e4
```

O comando `git grep `permite que um usuário procure através das árvores de conteúdo frases e / ou palavras. Por exemplo, para pesquisar www.git-scm.com em todos os arquivos use:

```sh
git grep "www.git-scm.com
```

O comando `gitk` é a interface gráfica para um repositório local que pode ser invocado digitando e executando:

```sh
gitk
```

O comando `git instaweb`, um servidor web pode ser executado em interface com o repositório local. Um navegador da Web também é automaticamente direcionado para ele. Por exemplo:

```sh
git instaweb –httpd=webrick
```

Para otimizar o repositório através da coleta de lixo, que irá limpar arquivos desnecessários e otimizá-los, use:

```sh
git gc
```


O comando `git archive` permite que um usuário crie um arquivo zip ou tar contendo os componentes de uma única árvore de repositório. Por exemplo:

```sh
git archive --format=tar master
```

Através do comando `git prune`, os objetos que não têm ponteiros de entrada são excluídos.

```sh
git prune
```

Para executar uma verificação de integridade do sistema de arquivos git, use o comando `git fsck`. Todos os objetos corrompidos são identificados:

```sh
git fsck
```

O comando `git rebase` é usado para reaplicação de compromissos em outro ramo. Por exemplo:

```sh
git rebase master
```

## Conclusão

Aqui foram alguns comandos Git básicos usados com frequência.

Segue material para se aprofundar mais sobre https://git-scm.com/book/en/v2.
