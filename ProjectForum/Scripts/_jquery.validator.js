


(function ($) {

	$.validator.setDefaults({
		errorClass: 'help-block',
		highlight: function (element) {
			$(element).closest('.form-group').addClass('has-error');
		}
	});

	$.validator.addMethod('strongPassword', function (value, element) {
		return this.optional(element) || value.length >= 6;
	}, "Your password must be at least 6 cahracters long");




	$('#logInForm').validate({
		rules: {
			Username:{
				required:true,
			},

			Password: {
				required: true,
				strongPassword: true
			}
		},

		messages: {
		    Username: {
				required: 'Please enter username',
			},
			Password: {
				required: 'Please enter password'
			}
		}
	});

	$('#signUpForm').validate({
		rules: {
			Email: {
				required: true,
				Email: true
			},

			Firstname: "required",
			Lastname: "required",
			RegisterUsername: "required",

			Password: {
				required: true,
				strongPassword: true
			},

			ConfirmPassword: {
				required: true,
				strongPassword: true,
				equalTo: '#password'
			}
		},

		messages: {
			Email: {
				required: 'Please enter Email',
				Email: 'Please enter <b>Valid</b> email address'
			},
			Firstname: {
				required: 'Please enter firstname'
			},
			Lastname: {
				required: 'Please enter lastname'
			},
			RegisterUsername: {
			    required: 'Please enter username'
			},
			Password: {
				required: 'Please enter password'
			},
			ConfirmPassword: {
				required: 'Please confirm password'
			}
		}
	})
})(jQuery);