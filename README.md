Exerciții pt cursul de .Net
Le voi organiza per lecții. Ca în caz de ne aflam în dificultate de a rezolva, sa avem o referință la lecția care poate fi revizitată.
Sunt exerciții opționale, doar pentru cei dornici de mai multa practică. 
Nu va descurajați dacă nu reușesc unele lucruri.
Dacă întâmpinați erori, puteți ca prim pas cauta pe google cu textul acelei erori. De multe ori, se găsește rapid o soluție. Mai ales dacă este o problema des întâlnită.
Dacă însă sunt dificultăți și așa, secțiunea Discussions este ca de obicei deschisă.
Spor.

Ce recomand ca mod de lucru: 
- Download repository-ului acesta (clone folosind GitHub desktop sau alt tool cu interfata pentru Github) 
- Exercitiile recomand sa fie lucrate si testate chiar pe copia locala a acestui proiect. 
Recomand asta fiindca aici voi pune exercitii cu sabloanele de cod pregatite, si in plus, teste unitare care ajuta la auto-evaluare. 

- Proiectul este organizat in directoare per lectii, menite sa fie abordate una dupa alta. 
In fiecare director, va exista cel putin o clasa cu un nume Lesson[X]. Daca intr-un director sunt mai multe clase, recomand ca punct de plecare pe cea cu numele Lesson[X].
De acolo, urmatorul punct de reper este functia Run(). Acesta este pattern-ul. La fiecare lectie -> intai cautam fisierul Lesson[X], apoi functia Run() din aceasta. 
Acolo vom gasi instructiunile si exercitiile. De acolo incepem cu cerintele, cu exemplele de ce rezultate se asteapta de la un anumit cod, etc.

- cand simtim o anumita problema/lectie rezolvata, avem optiunea de a rula testele unitare pentru a ne verifica. Acestea se gasesc in Visual Studio in  meniul Test -> Test explorer, pentru a le vedea si rula per grupuri, in functie de lectia rezolvata. Un cod care rezolva problema data ar trebui sa aiba doar rezultate cu succes (green check).

- proiectul de teste este si el atasat, asadar puteti analiza si prin acesta ce anume se testeaza, pentru a intelege de ce unele teste au un eventual rezultat fail. aici e pentru lucru individual asa ca aceasta forma de evaluare nu-mi doresc sa fie una stricta. de aceea va puteti uita ce se intampla prin teste. n-as recomanda insa sa le modificam chiar din prima. in prima faza, ar fi mai productiv sa incercam sa scriem codul care sa faca testele sa ruleze cu 100% pass. si doar daca apar probleme cu care ne blocam, atunci putem sa analizam mai detaliat si testele in sine, si eventual sa le modificam. 
