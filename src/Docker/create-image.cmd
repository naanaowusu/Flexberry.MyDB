docker build --no-cache -f SQL\Dockerfile.PostgreSql -t mydb/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t mydb/app ../..
