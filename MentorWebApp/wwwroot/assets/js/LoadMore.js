

$('.load').click(function (e) {
    e.preventDefault();

    let url = $(".load").attr("href")
   
    $.ajax({
        url: url,
        method: "GET",
        dataType: "json",
        success: function (response) {
            let a=""
            for (let i = 0; i < response.length; i++) {
                a += `
           <div class="col-lg-4 col-md-6 d-flex align-items-stretch">
            <div class="member">
              <img src="/assets/img/trainers/${response[i].image}" class="img-fluid" alt="">
              <div class="member-content">
                <h4>${response[i].name} ${response[i].surname}</h4>
                <span>${response[i].courseCategory.name}</span>
                <p>
                 ${response[i].info}
                </p>
                <div class="social">
                  <a href=""><i class="bi bi-twitter"></i></a>
                  <a href=""><i class="bi bi-facebook"></i></a>
                  <a href=""><i class="bi bi-instagram"></i></a>
                  <a href=""><i class="bi bi-linkedin"></i></a>
                </div>
              </div>
            </div>
          </div>`
                
            }
            $('.trainerrow').append(a)






   
        }
    })
})