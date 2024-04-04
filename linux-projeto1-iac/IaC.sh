#!/bin/bash

echo  "Diretórios criados.."

mkdir publico adm ven sec

echo "Grupos criados.."

groupadd GRP_ADM
groupadd GRP_VEN
groupadd GRP_SEC

echo "Usuários criados.."

useradd carlos -c "Carlos Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_ADM
useradd maria -c "Maria Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_ADM
useradd joao -c "João Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_ADM
useradd debora -c "Débora Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_VEN
useradd sebastiana -c "Sebastiana Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_VEN
useradd roberto -c "Roberto Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_VEN
useradd josefina -c "Josefina Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_SEC
useradd amanda -c "Amanda Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_SEC
useradd rogerio -c "Rogerio Silva" -m -s /bin/bash -p $(openssl passwd -1 senha123) -G GRP_SEC

echo "Permissões diretórios.."

chown root:GRP_ADM /adm/
chown root:GRP_VEN /ven/
chown root:GRP_SEC /sec/

echo "Permissões criadas.."

chmod 770 /adm/
chmod 770 /ven/
chmod 770 /sec/
chmod 777 /publico/

echo "Finalizado.."

