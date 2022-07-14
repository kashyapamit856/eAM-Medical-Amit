/*=========================================================================================
  File Name: auth-login.js
  Description: Auth login js file.
  ----------------------------------------------------------------------------------------
  Item Name: Vuexy  - Vuejs, HTML & Laravel Admin Dashboard Template
  Author: PIXINVENT
  Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/

//$(function () {
//  'use strict';

//  var pageLoginForm = $('.auth-login-form');

//  // jQuery Validation
//  // --------------------------------------------------------------------
//  if (pageLoginForm.length) {
//    pageLoginForm.validate({
//      /*
//      * ? To enable validation onkeyup
//      onkeyup: function (element) {
//        $(element).valid();
//      },*/
//      /*
//      * ? To enable validation on focusout
//      onfocusout: function (element) {
//        $(element).valid();
//      }, */
//      rules: {
//        'login-email': {
//          required: true,
//          email: true
//        },
//        'login-password': {
//          required: true
//        }
//      }
//    });
//  }
//});

// Example starter JavaScript for disabling form submissions if there are invalid fields
(function () {
    'use strict'

    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.querySelectorAll('.needs-validation')

    // Loop over them and prevent submission
    Array.prototype.slice.call(forms)
        .forEach(function (form) {
            form.addEventListener('submit', function (event) {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }

                form.classList.add('was-validated')
            }, false)
        })
})();
