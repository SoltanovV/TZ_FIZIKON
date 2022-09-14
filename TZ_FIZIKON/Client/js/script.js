const URL = 'https://localhost:7239/api/Cours/GetCourses'
const cours = fetch(URL)
    .then((res) => {
       return res.json();  
    }).then((data) => {
          data.map((c) => {
         
            let coursList = document.createElement('li')
            coursList.classList.add(c.id)
            coursList.setAttribute('id', c.id)
            coursList.textContent = c.title
            
            createCoursUl.appendChild(coursList)

            c.modules.map((m) => {
                let createMoledUl = document.createElement('ul')
                createMoledUl.classList.add('threeModel')
                createMoledUl.setAttribute('id', 'threeModel')
                createMoledUl.textContent = m.num + ' ' + m.title
                createCoursUl.appendChild(createMoledUl)
                coursList.appendChild(createMoledUl)
            })
        })
    })

    let divContainer = document.getElementById('container')
    let createCoursUl = document.createElement('ul')
    createCoursUl.classList.add('three')
    createCoursUl.setAttribute('id', 'three')
    divContainer.appendChild(createCoursUl)  
   
