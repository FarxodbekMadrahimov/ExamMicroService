Bu mening imthihon uchun micro service projectim bu projectda tez yordam va rustarant serive bor ammo ular toliq emas hali kamchiliklari bor. men ularga cashing , background service(oddiy background serive) 
docker qoshfim ammo docker databasega ulana olmagani uchun uni ishlata olmadim(docker database bilan ishlagan kuni shu readme.md ni oqigan odamga osh qberaman) database siz oddiy qoshilganda ishlayapti holos , ocelot va JWT larda kop hatolar chiqdi ularni ishlataman deb apilarim ishlamay qoldi , fluent api qoshilgan va bular SQRSda yozilgan .
Ambulance servicemni ishlatish uchun avvalo ozingiz uchun defaultconnectiom ti togirlashingiz kerak keyin bir marta migratsiya qilish kerak
ambulance serive ishlaganda birinchi navbatda ambulanceinfo da bitta post qilish kerak chunki unda tez yordam mashinsi va u bosh boshmasligi va emergencyc callga ambulanceinfo Id si kerak yaratiladi keyin esa emergency call yaratiladi keyin esa docktor unga emergency call id kerek va ohrida patient ungaham emergency call id kerek (yuqorida aytganim dek hali bu toliq emas)
va restaurent serive u juda oddiy yaratilgan  servicemni ishlatish uchun avvalo ozingiz uchun defaultconnectiom ti togirlashingiz kerak keyin bir marta migratsiya qilish kerak
bu seriveda menu itemga ovqat nomi narxi va decription qoshiladi keyin esa order va unda totalamunt yoziladi date esa hoziri vaqtni oladi
va ohrida order item qoshiladi unga menu item va order item idsi kerak unga qountitiy yoziladi 
va bu servicelarning hammasi CRUD ishlaydi 
dockerga tegmagan yaxhi chunki umuman ishlamay qoldi kechasi bilan togirlashga urnidm foydasi bolmadi
mabodo ishlab qolsa dockerni ozingizda ham yoqib qoyishingiz shart
