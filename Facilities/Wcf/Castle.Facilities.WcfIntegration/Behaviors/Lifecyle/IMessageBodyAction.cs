﻿// Copyright 2004-2008 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.Facilities.WcfIntegration.Behaviors
{
	using System.ServiceModel.Channels;
	using System.Xml;

	/// <summary>
	/// Basic contract for performing message actions that require access
	/// to the message body (i.e. modifications)
	/// </summary>
	public interface IMessageBodyAction : IMessageLifecyleAction
	{
		/// <summary>
		/// Performs the action on the suppplied <paramref name="message"/>.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="body">The message body.</param>
		/// <param name="lifecyle">The lifecycle stage.</param>
		/// <returns>true if further actions should be performed.</returns>
		bool Perform(Message message, XmlDocument body, MessageLifecycle lifecyle);
	}
}