# Práctica 2: Introducción a los scripts en Unity
* **Asignatura:** Interfaces Inteligentes
* **Autora:** Vanessa Valentina Villalba Pérez
* **Correo:** alu0101265704@ull.edu.es

## **Objetivos de la práctica y pasos realizados** 
1. **Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.**
   
    a. **Ninguno de los objetos será físico**

    Al no tener activado el *RigidBody*, no responden a la gravedad y durante la escena se quedan estáticos aunque se encuentren en una posición alejada al plano.

    ![No rigidBody](img/1.a.png)

    b. **La esfera tiene físicas, el cubo no**

    ![Sphere RigidBody](GIFs/gif_animation_007.gif)

    c. **La esfera y el cubo tienen físicas**

    ![Both RigidBody](GIFs/gif_animation_008.gif)
 
    ![Both RigidBody](GIFs/gif_animation_009.gif)

    d. **La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo**

    ![Both RigidBody and sphere mass x10](GIFs/gif_animation_015.gif)

    e. **La esfera tiene físicas y el cubo es de tipo IsTrigger**

    ![Both RigidBody and cube IsTrigger](GIFs/gif_animation_017.gif)


    f. **La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas**

    ![Both RigidBody and cube IsTrigger](GIFs/gif_animation_016.gif)
    
    g. **La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ**

    ![Both RigidBody and cube IsTrigger](GIFs/gif_animation_019.gif)
