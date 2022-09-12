
    const URL = 'https://localhost:7239/api/Home/GetCourses'
    fetch(URL)
        .then((res) =>{
            return res.json()
        })
            .then((data) => {
            console.log(data)
                data.map((cours) =>{
                    const  d  = document.querySelector('.s')
                    let title = document.createElement('h1')

                    title.textContent = cours.title

                    document.body.append(title);

                    cours.modules.map((mod) => {

                        //console.log(mod)
                    })
                    
                    //let modules = document.createElement('h2')
                    //const list = mod.num
                    //console.log(list)

                    //modules.textContent = mod.num + ' ' + mod.title

                        //for (var i = 0; i < mod.num.length; i++) {

                        //    if (list[i].length < list[i++].length) {
                        //        //document.body.append(modules);
                        //        s.appendChild(modules)
                        //    }
                        //}

                        //document.body.append(modules);
              
                })
            })