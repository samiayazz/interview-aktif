const users = JSON.parse('[{"FirstName":"John","LastName":"Doe","Age":20},{"FirstName":"Jane","LastName":"Doe","Age":25},{"FirstName":"Sami","LastName":"Ayaz","Age":21}]');

const table = document.querySelector('#usersTable');
users.forEach(user => {
    const tr = document.createElement('tr');

    const tdFirstName = document.createElement('td');
    const tdLastName = document.createElement('td');
    const tdAge = document.createElement('td');

    tdFirstName.textContent = user.FirstName;
    tdLastName.textContent = user.LastName;
    tdAge.textContent = user.Age;

    tr.appendChild(tdFirstName);
    tr.appendChild(tdLastName);
    tr.appendChild(tdAge);

    table.appendChild(tr);
});