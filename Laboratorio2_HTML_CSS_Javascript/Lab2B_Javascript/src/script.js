// Variable para controlar el color de fondo
let fondoOscuro = false;

// Función para agregar elementos
function agregar() {
    // Busca el elemento con id "lista" y obtiene la cantidad de elementos hijos para determinar el número del nuevo elemento
    let lista = document.getElementById("lista");
    // El número del nuevo elemento será el número de elementos actuales + 1
    let cantidad = lista.children.length + 1;
    // Crea un nuevo elemento de lista (li) y establece su contenido de texto
    let nuevoElemento = document.createElement("li");
    // El contenido del nuevo elemento será "Elemento" seguido del número correspondiente
    nuevoElemento.textContent = "Elemento" + cantidad;
    // Agrega el nuevo elemento a la lista
    lista.appendChild(nuevoElemento);
}

// Función para cambiar el fondo
function cambiarFondo() {
    if (fondoOscuro) {
        // Si el fondo es oscuro, cambia a blanco
        document.body.style.backgroundColor = "white";
        // Actualiza la variable para indicar que el fondo ya no es oscuro
        fondoOscuro = false;
    } else {
        document.body.style.backgroundColor = "lightblue";
        fondoOscuro = true;
    }
}

// Función para borrar el último elemento
function borrar() {
    // Busca el elemento con id "lista"
    let lista = document.getElementById("lista");
    // Verifica si la lista tiene elementos antes de intentar eliminar el último
    if (lista.children.length > 0) {
        lista.removeChild(lista.lastElementChild);
    }
}