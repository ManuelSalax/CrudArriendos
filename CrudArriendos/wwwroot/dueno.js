const apiUrl = 'https://localhost:7118/api/dueno'; // Cambia según tu URL y controlador

// DOM Elements
const duenoForm = document.getElementById('duenoForm');
const duenoTableBody = document.querySelector('#duenoTable tbody');

// ============================
// FUNCIONES CRUD
// ============================

// Listar Dueños
async function listarDuenos() {
    const res = await fetch(apiUrl);
    const data = await res.json();

    duenoTableBody.innerHTML = '';
    data.forEach(d => {
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${d.id}</td>
            <td>${d.nombre}</td>
            <td>${d.telefono}</td>
            <td>
                <button onclick="editarDueno(${d.id}, '${d.nombre}', '${d.telefono}')">Editar</button>
                <button onclick="eliminarDueno(${d.id})">Eliminar</button>
            </td>
        `;
        duenoTableBody.appendChild(row);
    });
}

// Crear o actualizar Dueño
duenoForm.addEventListener('submit', async (e) => {
    e.preventDefault();

    const dueno = {
        id: Number(document.getElementById('duenoId').value),
        nombre: document.getElementById('duenoNombre').value,
        telefono: document.getElementById('duenoTelefono').value
    };

    // Aquí asumimos que si existe el ID se actualiza, si no se crea
    const res = await fetch(apiUrl, {
        method: 'POST', // Cambiar a PUT si tu API tiene endpoint para actualizar
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(dueno)
    });

    if (res.ok) {
        listarDuenos();
        duenoForm.reset();
    } else {
        alert('Error al guardar el dueño');
    }
});

// Editar Dueño (rellena el formulario)
function editarDueno(id, nombre, telefono) {
    document.getElementById('duenoId').value = id;
    document.getElementById('duenoNombre').value = nombre;
    document.getElementById('duenoTelefono').value = telefono;
}

// Eliminar Dueño
async function eliminarDueno(id) {
    if (!confirm('¿Seguro que quieres eliminar este dueño?')) return;

    const res = await fetch(`${apiUrl}/${id}`, { method: 'DELETE' });
    if (res.ok) {
        listarDuenos();
    } else {
        alert('Error al eliminar el dueño');
    }
}

// ============================
// INICIALIZACIÓN
// ============================
listarDuenos();
