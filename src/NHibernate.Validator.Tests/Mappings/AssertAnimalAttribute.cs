using System;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Tests.Mappings
{
	[AttributeUsage(AttributeTargets.Class)]
	[ValidatorClass(typeof(AssertAnimalValidator))]
	public class AssertAnimalAttribute : Attribute, IRuleArgs
	{
		private string message = "not an animal";

		public string Message
		{
			get { return message; }
			set { message = value; }
		}
	}

	public class AssertAnimalValidator : IInitializableValidator<AssertAnimalAttribute>
	{
		public bool IsValid(object value, IConstraintValidatorContext constraintContext)
		{
			return value is MixSuricato;
		}

		public void Initialize(AssertAnimalAttribute parameters)
		{
			
		}
	}
}