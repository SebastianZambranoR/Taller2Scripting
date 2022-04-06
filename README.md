# Repositorio para el taller 2 de scripting.
Miembros:
Iuma Toro.
Sebastian Zambrano.
Se implementó la programación orientada a objetos de la siguiente manera:
Cada atributo de cada clase tiene un nivel de protección private (a excepción de los enum), y sólo se pueden acceder a ellos o modificar por medio de propiedades.

Se creó una superclase de Cartas la cual se marcó como abstracta para evitar que se instancie, y en su lugar las clases hijas SupportSkill, Character y Equip son aquellas que se pueden instanciar.
Se crearon las interfaces IEffect que actúa como puente entre supportskill y applyeffect, luego, con un switchcase se recibe el tipo de efecto para realizar la consecuencia determinada 

Se implementaron pruebas unitarias en lugar de aplicación de consola
