docker volume create mysql_data_volume
docker run -d \
    --name mysql_container \
    -e MYSQL_ROOT_PASSWORD=rootpassword \
    -v mysql_data_volume:/var/lib/mysql \
    mysql:latest
    docker run --rm \
    --name backup_container \
    -v mysql_data_volume:/var/lib/mysql \
    -v /path/on/your/pc:/backup \
    busybox \
    cp -r /var/lib/mysql /backup