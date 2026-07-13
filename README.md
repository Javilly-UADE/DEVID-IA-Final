# Final Regular - Inteligencia Artificial en Videojuegos

## Introducción

En este repositorio se entrega una escena base en Unity con una plataforma, un jugador, un enemigo, uno o más obstáculos y una carpeta de scripts ya creada.

El objetivo del examen es completar la parte teórica y resolver la parte práctica a partir de esta base.

---

## Parte teórica

Responder las siguientes preguntas de forma clara y breve.

1. Explicá qué problema resuelve un sistema de **Line of Sight** y qué elementos suelen intervenir en su implementación.

2. Explicá una diferencia importante entre una **FSM** y un **Decision Tree**.

3. Explicá la diferencia entre los Steering Behaviours **Seek**, **Pursue** y **Evade**.

4. Explicá qué diferencia hay entre **BFS** y **DFS**. Indicá además cuál de los dos conviene más para encontrar un camino mínimo en un grafo sin peso y por qué.

5. Explicá qué problema resuelve **Dijkstra** y en qué se diferencia de **BFS**.

6. Explicá qué agrega **A\*** respecto de **Dijkstra** y qué rol cumple la **heurística**.

7. Explicá qué mejora aporta **Theta\*** respecto de **A\***.

8. Explicá qué es **Flocking** y nombrá sus tres reglas principales, indicando brevemente qué hace cada una.

---

## Parte práctica

Completar lo necesario para que el enemigo pueda encontrar y recorrer correctamente un camino dentro de la escena.

### Tareas

- Configurar correctamente el **NodeManager** para que los nodos se generen de forma útil sobre la plataforma.
- Configurar correctamente el **ExerciseManager** para que pueda utilizar correctamente los objetos de la escena.
- Revisar y completar la implementación de **Dijkstra**.
- Lograr que el enemigo recorra correctamente el camino encontrado.
- Hacer que el recorrido final respete la disposición de nodos y no atraviese obstáculos.

---

## Entrega esperada

Al finalizar, el proyecto debería permitir que el enemigo:

- utilice una red de nodos válida en la plataforma
- encuentre un camino desde el punto inicial hasta el objetivo
- recorra ese camino correctamente dentro de la escena
