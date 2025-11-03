# CINEMACHINE 
## Introducción a Unity 2D - Cámara

En esta práctica se trabajó con **Cinemachine**, un sistema avanzado de control de cámaras en Unity, para explorar diferentes formas de seguimiento, efectos y transiciones de cámara en un juego 2D. Cada tarea implementó funcionalidades específicas que mejoran la experiencia de juego y la presentación visual.

---

### 1. Configuración de cámaras virtuales con diferentes zonas de seguimiento.

Se instalaron dos cámaras virtuales y se configuraron para seguir al jugador, asignando zonas de seguimiento distintas: Dead Zone, Soft Zone y Hard Zone. Esto permitió controlar cómo y cuándo la cámara se mueve con el personaj8e. 

[Ejercicio1](Imagenes/1.gif)


### 2. Zona de confinamiento
Se utilizó la extensión **Cinemachine Confiner** para restringir el movimiento de cada cámara dentro de un área definida del mapa, usando un **Polygon Collider 2D** en el fondo del escenario. Esto aseguró que la cámara no mostrara áreas vacías o fuera del juego y permitió definir límites distintos para cada cámara. El resultado se comprobó mediante un GIF, observando cómo la cámara se mantiene confinada mientras el jugador se desplaza.

---

### 3. Seguimiento a un grupo de objetivos
Se creó una **Target Group Camera** que siguió simultáneamente a varios objetos en movimiento (mínimo tres). Se configuraron los **pesos** de cada objeto para ajustar su importancia en el encuadre. Esto permitió que la cámara centrara la vista en los elementos más relevantes y mantuviera todos los objetos visibles, simulando un seguimiento grupal. La prueba mostró que la cámara ajusta su posición de forma dinámica según el movimiento del grupo.

---

### 4. Impulso (shake)
Se implementó un efecto de sacudida usando **Cinemachine Impulse Source**, generando perturbaciones en la cámara cuando ocurre un evento específico, como una explosión o colisión. Esto añade realismo y dinamismo a la escena, simulando que la cámara reacciona al impacto en el entorno. Se observó que la sacudida se activa solo durante el evento, regresando a la normalidad después.

---

### 5. Zoom controlado por teclado
Se creó un script que ajusta el **zoom de la cámara** con las teclas `W` y `S`, modificando la propiedad `Lens.OrthographicSize`. Esto permite al jugador acercar o alejar la vista del entorno de manera dinámica, facilitando la exploración o concentración en detalles específicos del juego. Durante la prueba se notó cómo la cámara cambia suavemente su tamaño sin afectar la jugabilidad.

---

### 6. Intercambio de cámaras con teclado
Se implementó un sistema que activa o desactiva dos cámaras virtuales usando las teclas `1` y `2`. Esto permitió cambiar la perspectiva del jugador en tiempo real, mostrando cómo se puede alternar entre diferentes encuadres de forma rápida y sencilla mediante scripts, sin necesidad de modificar manualmente las cámaras en la escena.

---

### 7. Intercambio de cámaras mediante UI
Se añadió una **interfaz de usuario** con botones que permiten activar cada cámara al ser pulsados. Esto integra un método visual de selección de cámara, útil para juegos donde el jugador debe cambiar la perspectiva de forma intuitiva, combinando interacción visual con control dinámico de las cámaras.

---

### 8. Cámara lenta y rápida
Se implementaron cámaras adicionales que modifican la **velocidad de juego** usando `Time.timeScale`. Al colisionar con objetos específicos, se ralentizó el tiempo a 0.3 para la cámara lenta y se aceleró a 2 para la cámara rápida, activando y desactivando las cámaras correspondientes. Esto demostró cómo Cinemachine puede combinarse con efectos de tiempo para crear sensaciones dramáticas o aumentar la intensidad de la acción.

---

### 9. Transición entre cámaras usando prioridad
Se configuró un cambio de cámara mediante la propiedad `Priority`. Al colisionar con un objeto, la cámara confinada adquiría mayor prioridad sobre la cámara normal y viceversa. Esto permitió realizar **transiciones suaves** entre cámaras activas, aprovechando la propiedad de mezcla de Cinemachine, y evidenció cómo controlar dinámicamente qué cámara se muestra en cada situación.

---

### 10. Conclusión
La práctica mostró cómo Cinemachine facilita el control avanzado de cámaras en Unity. Se implementaron múltiples técnicas: seguimiento individual y grupal, confinamiento, zoom dinámico, cambios de cámara por teclado y UI, efectos de impulso, cámaras lenta y rápida, y transición por prioridad. Cada tarea permitió comprender cómo estas herramientas mejoran la jugabilidad y la presentación visual en un juego 2D, haciendo la experiencia más inmersiva y profesional.

